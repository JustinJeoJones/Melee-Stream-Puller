namespace MeleeStreamInfo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonURLSearch = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxScore1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxScore2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonXML = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCommentator = new System.Windows.Forms.TextBox();
            this.textBoxCommentator2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxP1 = new System.Windows.Forms.ComboBox();
            this.comboBoxP2 = new System.Windows.Forms.ComboBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonSwitchScore = new System.Windows.Forms.Button();
            this.buttonSwitchChara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 12);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(208, 20);
            this.textBoxURL.TabIndex = 0;
            // 
            // buttonURLSearch
            // 
            this.buttonURLSearch.Location = new System.Drawing.Point(226, 10);
            this.buttonURLSearch.Name = "buttonURLSearch";
            this.buttonURLSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonURLSearch.TabIndex = 1;
            this.buttonURLSearch.Text = "Find/Update";
            this.buttonURLSearch.UseVisualStyleBackColor = true;
            this.buttonURLSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 35);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(133, 13);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "Add a url and press search";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(12, 94);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(289, 316);
            this.listBoxResults.TabIndex = 3;
            this.listBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBoxResults_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Results";
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(307, 94);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(100, 20);
            this.textBoxP1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Player 1";
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(482, 94);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(100, 20);
            this.textBoxP2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Player 2";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(307, 225);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Tournament Name";
            // 
            // textBoxRound
            // 
            this.textBoxRound.Location = new System.Drawing.Point(482, 225);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.Size = new System.Drawing.Size(100, 20);
            this.textBoxRound.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Round";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 65);
            this.label6.TabIndex = 14;
            this.label6.Text = "App made by : Justin \"Jeo\" Jones \r\n2019 V 1.2\r\n\r\n\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxScore1
            // 
            this.textBoxScore1.Location = new System.Drawing.Point(307, 137);
            this.textBoxScore1.Name = "textBoxScore1";
            this.textBoxScore1.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "Player 1 Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 170;
            this.label8.Text = "Player 2 Score";
            // 
            // textBoxScore2
            // 
            this.textBoxScore2.Location = new System.Drawing.Point(482, 138);
            this.textBoxScore2.Name = "textBoxScore2";
            this.textBoxScore2.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore2.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonXML
            // 
            this.buttonXML.Location = new System.Drawing.Point(361, 387);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(210, 23);
            this.buttonXML.TabIndex = 15;
            this.buttonXML.Text = "XML Search";
            this.buttonXML.UseVisualStyleBackColor = true;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 200;
            this.label9.Text = "Commentator 1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxCommentator
            // 
            this.textBoxCommentator.Location = new System.Drawing.Point(307, 268);
            this.textBoxCommentator.Name = "textBoxCommentator";
            this.textBoxCommentator.Size = new System.Drawing.Size(100, 20);
            this.textBoxCommentator.TabIndex = 12;
            // 
            // textBoxCommentator2
            // 
            this.textBoxCommentator2.Location = new System.Drawing.Point(482, 268);
            this.textBoxCommentator2.Name = "textBoxCommentator2";
            this.textBoxCommentator2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCommentator2.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 230;
            this.label10.Text = "Commentator 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 231;
            this.label11.Text = "Player 1 Character";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(482, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 232;
            this.label12.Text = "Player 2 Character";
            // 
            // comboBoxP1
            // 
            this.comboBoxP1.FormattingEnabled = true;
            this.comboBoxP1.Location = new System.Drawing.Point(307, 180);
            this.comboBoxP1.Name = "comboBoxP1";
            this.comboBoxP1.Size = new System.Drawing.Size(100, 21);
            this.comboBoxP1.TabIndex = 233;
            this.comboBoxP1.SelectedIndexChanged += new System.EventHandler(this.comboBoxP1_SelectedIndexChanged);
            // 
            // comboBoxP2
            // 
            this.comboBoxP2.FormattingEnabled = true;
            this.comboBoxP2.Location = new System.Drawing.Point(482, 180);
            this.comboBoxP2.Name = "comboBoxP2";
            this.comboBoxP2.Size = new System.Drawing.Size(100, 21);
            this.comboBoxP2.TabIndex = 234;
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.Location = new System.Drawing.Point(413, 92);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(63, 23);
            this.buttonSwitch.TabIndex = 235;
            this.buttonSwitch.Text = "Switch";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSwitchScore
            // 
            this.buttonSwitchScore.Location = new System.Drawing.Point(413, 136);
            this.buttonSwitchScore.Name = "buttonSwitchScore";
            this.buttonSwitchScore.Size = new System.Drawing.Size(63, 23);
            this.buttonSwitchScore.TabIndex = 236;
            this.buttonSwitchScore.Text = "Switch";
            this.buttonSwitchScore.UseVisualStyleBackColor = true;
            this.buttonSwitchScore.Click += new System.EventHandler(this.buttonSwitchScore_Click);
            // 
            // buttonSwitchChara
            // 
            this.buttonSwitchChara.Location = new System.Drawing.Point(413, 178);
            this.buttonSwitchChara.Name = "buttonSwitchChara";
            this.buttonSwitchChara.Size = new System.Drawing.Size(63, 23);
            this.buttonSwitchChara.TabIndex = 237;
            this.buttonSwitchChara.Text = "Switch";
            this.buttonSwitchChara.UseVisualStyleBackColor = true;
            this.buttonSwitchChara.Click += new System.EventHandler(this.buttonSwitchChara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 445);
            this.Controls.Add(this.buttonSwitchChara);
            this.Controls.Add(this.buttonSwitchScore);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.comboBoxP2);
            this.Controls.Add(this.comboBoxP1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCommentator2);
            this.Controls.Add(this.textBoxCommentator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonXML);
            this.Controls.Add(this.textBoxScore2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxScore1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonURLSearch);
            this.Controls.Add(this.textBoxURL);
            this.Name = "Form1";
            this.Text = "Melee Match Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonURLSearch;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxScore1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxScore2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCommentator;
        private System.Windows.Forms.TextBox textBoxCommentator2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxP1;
        private System.Windows.Forms.ComboBox comboBoxP2;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonSwitchScore;
        private System.Windows.Forms.Button buttonSwitchChara;
    }
}

