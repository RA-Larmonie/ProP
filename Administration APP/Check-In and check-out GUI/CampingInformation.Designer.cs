namespace Check_In_and_check_out_GUI
{
    partial class CampingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampingInformation));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tBAvailableCampSpots = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAvailableCamping = new System.Windows.Forms.ListBox();
            this.lbTakenCamping = new System.Windows.Forms.ListBox();
            this.tBCampID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TimerCamping = new System.Windows.Forms.Timer(this.components);
            this.tBNumberOfTakenSpots = new System.Windows.Forms.TextBox();
            this.LbEndDate = new System.Windows.Forms.Label();
            this.LbAvailableSpots = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LbStartDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LbCampInfo = new System.Windows.Forms.ListBox();
            this.LbSpotsAvailable = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.button1.Location = new System.Drawing.Point(709, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(255, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(283, 46);
            this.label18.TabIndex = 18;
            this.label18.Text = "Camping information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Location = new System.Drawing.Point(1, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 23);
            this.panel3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label4.Location = new System.Drawing.Point(196, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "/100";
            // 
            // tBAvailableCampSpots
            // 
            this.tBAvailableCampSpots.Enabled = false;
            this.tBAvailableCampSpots.Location = new System.Drawing.Point(61, 152);
            this.tBAvailableCampSpots.Name = "tBAvailableCampSpots";
            this.tBAvailableCampSpots.Size = new System.Drawing.Size(110, 22);
            this.tBAvailableCampSpots.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label5.Location = new System.Drawing.Point(47, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Available camping spots:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label6.Location = new System.Drawing.Point(530, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Taken camping spots:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label7.Location = new System.Drawing.Point(687, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 27);
            this.label7.TabIndex = 27;
            this.label7.Text = "/100";
            // 
            // lbAvailableCamping
            // 
            this.lbAvailableCamping.FormattingEnabled = true;
            this.lbAvailableCamping.ItemHeight = 16;
            this.lbAvailableCamping.Location = new System.Drawing.Point(12, 193);
            this.lbAvailableCamping.Name = "lbAvailableCamping";
            this.lbAvailableCamping.Size = new System.Drawing.Size(367, 100);
            this.lbAvailableCamping.TabIndex = 28;
            this.lbAvailableCamping.SelectedIndexChanged += new System.EventHandler(this.lbAvailableCamping_SelectedIndexChanged);
            // 
            // lbTakenCamping
            // 
            this.lbTakenCamping.FormattingEnabled = true;
            this.lbTakenCamping.ItemHeight = 16;
            this.lbTakenCamping.Location = new System.Drawing.Point(396, 193);
            this.lbTakenCamping.Name = "lbTakenCamping";
            this.lbTakenCamping.Size = new System.Drawing.Size(367, 100);
            this.lbTakenCamping.TabIndex = 29;
            // 
            // tBCampID
            // 
            this.tBCampID.Location = new System.Drawing.Point(200, 86);
            this.tBCampID.Name = "tBCampID";
            this.tBCampID.Size = new System.Drawing.Size(160, 22);
            this.tBCampID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Camping number:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(92, 114);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(216, 31);
            this.btnCheck.TabIndex = 32;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.LbSpotsAvailable);
            this.panel1.Controls.Add(this.LbCampInfo);
            this.panel1.Controls.Add(this.LbEndDate);
            this.panel1.Controls.Add(this.LbAvailableSpots);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LbStartDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.tBCampID);
            this.panel1.Location = new System.Drawing.Point(1, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 302);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Specific camping information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.Location = new System.Drawing.Point(-2, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 23);
            this.panel4.TabIndex = 23;
            // 
            // TimerCamping
            // 
            this.TimerCamping.Interval = 10000;
            this.TimerCamping.Tick += new System.EventHandler(this.TimerCamping_Tick);
            // 
            // tBNumberOfTakenSpots
            // 
            this.tBNumberOfTakenSpots.Enabled = false;
            this.tBNumberOfTakenSpots.Location = new System.Drawing.Point(560, 152);
            this.tBNumberOfTakenSpots.Name = "tBNumberOfTakenSpots";
            this.tBNumberOfTakenSpots.Size = new System.Drawing.Size(110, 22);
            this.tBNumberOfTakenSpots.TabIndex = 35;
            // 
            // LbEndDate
            // 
            this.LbEndDate.AutoSize = true;
            this.LbEndDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbEndDate.Location = new System.Drawing.Point(107, 259);
            this.LbEndDate.Name = "LbEndDate";
            this.LbEndDate.Size = new System.Drawing.Size(80, 27);
            this.LbEndDate.TabIndex = 57;
            this.LbEndDate.Text = "<------->";
            // 
            // LbAvailableSpots
            // 
            this.LbAvailableSpots.AutoSize = true;
            this.LbAvailableSpots.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbAvailableSpots.Location = new System.Drawing.Point(739, 28);
            this.LbAvailableSpots.Name = "LbAvailableSpots";
            this.LbAvailableSpots.Size = new System.Drawing.Size(0, 27);
            this.LbAvailableSpots.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label8.Location = new System.Drawing.Point(11, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 27);
            this.label8.TabIndex = 54;
            this.label8.Text = "Available spots:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label9.Location = new System.Drawing.Point(13, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 27);
            this.label9.TabIndex = 53;
            this.label9.Text = "End date:";
            // 
            // LbStartDate
            // 
            this.LbStartDate.AutoSize = true;
            this.LbStartDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbStartDate.Location = new System.Drawing.Point(107, 211);
            this.LbStartDate.Name = "LbStartDate";
            this.LbStartDate.Size = new System.Drawing.Size(80, 27);
            this.LbStartDate.TabIndex = 51;
            this.LbStartDate.Text = "<------->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label13.Location = new System.Drawing.Point(11, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 27);
            this.label13.TabIndex = 49;
            this.label13.Text = "Start date:";
            // 
            // LbCampInfo
            // 
            this.LbCampInfo.FormattingEnabled = true;
            this.LbCampInfo.ItemHeight = 16;
            this.LbCampInfo.Location = new System.Drawing.Point(417, 15);
            this.LbCampInfo.Name = "LbCampInfo";
            this.LbCampInfo.Size = new System.Drawing.Size(367, 276);
            this.LbCampInfo.TabIndex = 36;
            // 
            // LbSpotsAvailable
            // 
            this.LbSpotsAvailable.AutoSize = true;
            this.LbSpotsAvailable.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbSpotsAvailable.Location = new System.Drawing.Point(160, 160);
            this.LbSpotsAvailable.Name = "LbSpotsAvailable";
            this.LbSpotsAvailable.Size = new System.Drawing.Size(80, 27);
            this.LbSpotsAvailable.TabIndex = 58;
            this.LbSpotsAvailable.Text = "<------->";
            this.LbSpotsAvailable.Click += new System.EventHandler(this.LbSpotsAvailable_Click);
            // 
            // CampingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(797, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBNumberOfTakenSpots);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbTakenCamping);
            this.Controls.Add(this.lbAvailableCamping);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBAvailableCampSpots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CampingInformation";
            this.Text = "Camping Information";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBAvailableCampSpots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbAvailableCamping;
        private System.Windows.Forms.ListBox lbTakenCamping;
        private System.Windows.Forms.TextBox tBCampID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer TimerCamping;
        private System.Windows.Forms.TextBox tBNumberOfTakenSpots;
        private System.Windows.Forms.Label LbEndDate;
        private System.Windows.Forms.Label LbAvailableSpots;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbStartDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox LbCampInfo;
        private System.Windows.Forms.Label LbSpotsAvailable;
    }
}