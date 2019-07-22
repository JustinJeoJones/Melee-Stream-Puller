using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace MeleeStreamInfo
{
    public partial class Form1 : Form
    {
        private string url;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Text = "Clicked!";
            listBoxResults.Items.Clear();
            url = textBoxURL.Text;
            if(url == "")
            {
                labelError.Text = "Nothing was added to the url box.";
            }
            else
            {
                if (url.ToLower().Contains("challonge.com"))
                {
                    labelError.Text = "Challonge link found. Pulling data now.";
                    challonge();
                }
                else if (url.ToLower().Contains("smash.gg"))
                {
                    labelError.Text = "Smash.gg link found. Pulling data now.";
                    smashGG();
                }
            }
        }

        private void smashGG()
        {
            listBoxResults.Items.Clear();
            string[] edit = url.Split('/');
            url = "https://api.smash.gg/phase_group/" + edit.Last() + "?expand[]=sets&expand[]=seeds";
            
            JObject JsonData = JObject.Parse(GET(url ));
            JObject Data = (JObject)JsonData["entities"];
            foreach (JObject set in Data["sets"])
            {
                Match match = new Match();
                if ((string)set["completedAt"] == null)
                {
                    match.player1 = (string)set["entrant1Id"];
                    match.player2 = (string)set["entrant2Id"];
                    if (match.player1 == null || match.player2 == null)
                    {
                        continue;
                    }
                    match.round = (string)set["fullRoundText"];
                    bool check1 = false;
                    bool check2 = false;
                    foreach (JObject playerData in Data["seeds"])
                    {
                        //foreach (JObject player in playerData["mutations"]["entrants"])
                        //{

                        try
                        {
                            if (((string)playerData["mutations"]["entrants"][match.player1]["id"] == match.player1) && (!check1))
                            {

                                match.player1 = (string)playerData["mutations"]["entrants"][match.player1]["name"];
                                check1 = true;
                            }
                        }
                        catch { labelError.Text = "Not found"; }
                        try
                        {
                            if (((string)playerData["mutations"]["entrants"][match.player2]["id"] == match.player2) && (!check2))
                            {
                                match.player2 = (string)playerData["mutations"]["entrants"][match.player2]["name"];
                                check2 = true;
                            }
                        }
                        catch { labelError.Text = "Not found"; }
                        if (check1 && check2)
                        {
                            break;
                        }
                    }

                    //}

                    listBoxResults.Items.Add(match);
                    labelError.Text = "Match added";
                }
            }
            labelError.Text = "All matches added";
        }

        private void challonge()
        {
            listBoxResults.Items.Clear();
            JObject JsonData = JObject.Parse(GET(url + ".json"));
            JObject bracket = (JObject)JsonData["matches_by_round"];

            int i = 1;

            while (true)
            {
                try
                {

                    string matchid = i + "";
                    foreach (JObject x in bracket[matchid])
                    {
                        Match match = new Match();
                        match.player1 = ((string)x["player1"]["display_name"]);
                        match.player2 = ((string)x["player2"]["display_name"]);

                        if (i < 0)
                        {
                            match.round = "Losers Round " + i * -1;
                        }
                        else
                        {
                            match.round = "Winners Round " + i;
                        }



                        string complete = ((string)x["state"]);


                        if (complete !="complete"&& complete != "pending")
                        {
                            listBoxResults.Items.Add(match);
                        }


                        
                    }
                    i = i * -1;
                    if (i > 0)
                    {
                        i++;
                    }
                }
                catch
                {
                    labelError.Text = "All matches pulled";

                    break;
                }
            }


        }

        private string GET(string urlInput)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlInput);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            writeFile("assests/p1.txt", textBoxP1.Text);
            writeFile("assests/p2.txt", textBoxP2.Text);
            writeFile("assests/name.txt", textBoxName.Text);
            writeFile("assests/round.txt", textBoxRound.Text);
            labelError.Text = "Files updated!";
        }
        private void writeFile(string name, string info)
        {
            StreamWriter writer = new StreamWriter(name);
            writer.WriteLine(info);
            writer.Close();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = (Match)listBoxResults.SelectedItem;
            textBoxP1.Text = match.player1;
            textBoxP2.Text = match.player2;
            textBoxRound.Text = match.round;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
