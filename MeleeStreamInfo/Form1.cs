using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace MeleeStreamInfo
{
    public partial class Form1 : Form
    {
        private string url;

        private string xmlFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlFile = readXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Text = "Clicked!";
            listBoxResults.Items.Clear();
            url = textBoxURL.Text; //url is global to make it easier to work with
            if(url == "")
            {
                labelError.Text = "Nothing was added to the url box.";
            }
            else
            {
                if (url.ToLower().Contains("challonge.com")) //detects which link it is and moves to corresponding method
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

        private void smashGG() //Data is intense, this runs slow
        {
            listBoxResults.Items.Clear();
            string[] edit = url.Split('/');
            url = "https://api.smash.gg/phase_group/" + edit.Last() + "?expand[]=sets&expand[]=seeds";
            
            JObject JsonData = JObject.Parse(GET(url ));
            JObject Data = (JObject)JsonData["entities"];
            foreach (JObject set in Data["sets"]) //goes through all pulled matches
            {
                Match match = new Match();
                if ((string)set["completedAt"] == null) //continues if not completed
                {
                    //have to pull id's to check against all registered players. Need to figure out how to make this more efficent 
                    match.player1 = (string)set["entrant1Id"]; 
                    match.player2 = (string)set["entrant2Id"];
                    if (match.player1 == null || match.player2 == null) //if it returns null it is a bye or the oppentant hasn't made it this far
                    {
                        continue;
                    }
                    match.round = (string)set["fullRoundText"];
                    //checks used to see if players were pulled. once both are true it stops to speed it up
                    bool check1 = false;
                    bool check2 = false;
                    foreach (JObject playerData in Data["seeds"])//data is complex. have to check every player entered's id to see if it matches the match
                    {
                        try
                        {
                            if (((string)playerData["mutations"]["entrants"][match.player1]["id"] == match.player1) && (!check1)) //checks id against the match. doesn't do this check if check is positive
                            {
                                match.player1 = (string)playerData["mutations"]["entrants"][match.player1]["name"];
                                check1 = true;
                            }
                        }
                        catch { labelError.Text = "Not found"; }
                        try
                        {
                            if (((string)playerData["mutations"]["entrants"][match.player2]["id"] == match.player2) && (!check2)) //checks id against the match. doesn't do this check if check is positive
                            {
                                match.player2 = (string)playerData["mutations"]["entrants"][match.player2]["name"];
                                check2 = true;
                            }
                        }
                        catch { labelError.Text = "Not found"; }
                        if (check1 && check2) //once both are checked, breaks to stop the loop
                        {
                            break;
                        }
                    }
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
            int i = 1; //challonge does their rounds like 1,-1,2,-2,3 so you have to manually keep track
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
                        //winners is positive, losers is negative
                        if (i < 0)
                        {
                            match.round = "Losers Round " + i * -1;
                        }
                        else
                        {
                            match.round = "Winners Round " + i;
                        }
                        string complete = ((string)x["state"]);
                        if (complete !="complete"&& complete != "pending") //only accepts matches that haven't started. should move this to save time on match making
                        {
                            listBoxResults.Items.Add(match);
                        }
                    }
                    //flips positive and negatives so all rounds are accounted for
                    i = i * -1;
                    //if it becomes positive we move to the next round
                    if (i > 0)
                    {
                        i++;
                    }
                }
                catch //once it detects that the newest round doesn't exist, there are no more rounds left to pull
                {
                    labelError.Text = "All matches pulled";
                    break;
                }
            }
        }

        private string GET(string urlInput)
        {
            //used to get the data from the links
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
            //plain text updates
            writeFile("assests/pName1.txt", textBoxP1.Text);
            writeFile("assests/pName2.txt", textBoxP2.Text);
            writeFile("assests/gTitle.txt", textBoxName.Text);
            writeFile("assests/gTitle2.txt", textBoxRound.Text);
            writeFile("assests/p1Score.txt", textBoxScore1.Text);
            writeFile("assests/p2Score.txt", textBoxScore2.Text);
            //xml file updates
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode node = doc.DocumentElement.SelectSingleNode("/items/pName1");
            node.InnerText = textBoxP1.Text;
            node = doc.DocumentElement.SelectSingleNode("/items/pName2");
            node.InnerText = textBoxP2.Text;
            node = doc.DocumentElement.SelectSingleNode("/items/gTitle");
            node.InnerText = textBoxName.Text;
            node = doc.DocumentElement.SelectSingleNode("/items/gTitle2");
            node.InnerText = textBoxRound.Text;
            node = doc.DocumentElement.SelectSingleNode("/items/pScore1");
            node.InnerText = textBoxScore1.Text;
            node = doc.DocumentElement.SelectSingleNode("/items/pScore2");
            node.InnerText = textBoxScore2.Text;

            doc.Save(xmlFile);
            labelError.Text = "Files updated!";
        }
        private void writeFile(string name, string info)
        {
            //used to write plain text files
            StreamWriter writer = new StreamWriter(name);
            writer.WriteLine(info);
            writer.Close();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pulls match info from selected
            Match match = (Match)listBoxResults.SelectedItem;
            textBoxP1.Text = match.player1;
            textBoxP2.Text = match.player2;
            textBoxRound.Text = match.round;
            //resets score counter
            textBoxScore1.Text = "0";
            textBoxScore2.Text = "0";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private string readXML()
        {
            StreamReader sr = new StreamReader("assests/xml/xmlFileLocation.txt");
            string result = sr.ReadLine();
            sr.Close();
            return result;
            
        }
        private void buttonXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "XML Files|*.xml";
            openFileDialog1.DefaultExt = "xml";
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                xmlFile=openFileDialog1.FileName.Trim();
                writeFile("assests/xml/xmlFileLocation.txt", xmlFile);
                labelError.Text = xmlFile;
            }
            else
            {
                labelError.Text = "Could not load the file";
            }
        }
    }
}
