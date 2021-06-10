namespace Check_In_and_check_out_GUI
{
    partial class VisitorInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorInformation));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbInfoBought = new System.Windows.Forms.ListBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbCampingStatus = new System.Windows.Forms.Label();
            this.LbEvenstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbFirstName = new System.Windows.Forms.Label();
            this.LbLastName = new System.Windows.Forms.Label();
            this.LbBalance = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbProductLoaned = new System.Windows.Forms.Label();
            this.LbBuy = new System.Windows.Forms.Label();
            this.LbVisitorHistory = new System.Windows.Forms.ListBox();
            this.tBUserId = new System.Windows.Forms.TextBox();
            this.timerVisitor = new System.Windows.Forms.Timer(this.components);
            this.LbLoaned = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.button1.Location = new System.Drawing.Point(776, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 70);
            this.panel2.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(313, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(255, 46);
            this.label18.TabIndex = 18;
            this.label18.Text = "Visitor information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Location = new System.Drawing.Point(-1, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 23);
            this.panel3.TabIndex = 23;
            // 
            // lbInfoBought
            // 
            this.lbInfoBought.FormattingEnabled = true;
            this.lbInfoBought.ItemHeight = 16;
            this.lbInfoBought.Location = new System.Drawing.Point(12, 145);
            this.lbInfoBought.Name = "lbInfoBought";
            this.lbInfoBought.Size = new System.Drawing.Size(376, 180);
            this.lbInfoBought.TabIndex = 27;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(442, 179);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(412, 38);
            this.BtnCheck.TabIndex = 29;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label2.Location = new System.Drawing.Point(448, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Check visitor by user ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label3.Location = new System.Drawing.Point(437, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Event status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label4.Location = new System.Drawing.Point(648, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 36;
            this.label4.Text = "Camping status";
            // 
            // LbCampingStatus
            // 
            this.LbCampingStatus.AutoSize = true;
            this.LbCampingStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbCampingStatus.Location = new System.Drawing.Point(786, 234);
            this.LbCampingStatus.Name = "LbCampingStatus";
            this.LbCampingStatus.Size = new System.Drawing.Size(80, 27);
            this.LbCampingStatus.TabIndex = 38;
            this.LbCampingStatus.Text = "<------->";
            // 
            // LbEvenstatus
            // 
            this.LbEvenstatus.AutoSize = true;
            this.LbEvenstatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbEvenstatus.Location = new System.Drawing.Point(552, 234);
            this.LbEvenstatus.Name = "LbEvenstatus";
            this.LbEvenstatus.Size = new System.Drawing.Size(80, 27);
            this.LbEvenstatus.TabIndex = 37;
            this.LbEvenstatus.Text = "<------->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label1.Location = new System.Drawing.Point(648, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label5.Location = new System.Drawing.Point(437, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "First name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label6.Location = new System.Drawing.Point(437, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "Balance:";
            // 
            // LbFirstName
            // 
            this.LbFirstName.AutoSize = true;
            this.LbFirstName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbFirstName.Location = new System.Drawing.Point(552, 279);
            this.LbFirstName.Name = "LbFirstName";
            this.LbFirstName.Size = new System.Drawing.Size(80, 27);
            this.LbFirstName.TabIndex = 43;
            this.LbFirstName.Text = "<------->";
            // 
            // LbLastName
            // 
            this.LbLastName.AutoSize = true;
            this.LbLastName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbLastName.Location = new System.Drawing.Point(789, 279);
            this.LbLastName.Name = "LbLastName";
            this.LbLastName.Size = new System.Drawing.Size(80, 27);
            this.LbLastName.TabIndex = 42;
            this.LbLastName.Text = "<------->";
            // 
            // LbBalance
            // 
            this.LbBalance.AutoSize = true;
            this.LbBalance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbBalance.Location = new System.Drawing.Point(552, 327);
            this.LbBalance.Name = "LbBalance";
            this.LbBalance.Size = new System.Drawing.Size(80, 27);
            this.LbBalance.TabIndex = 44;
            this.LbBalance.Text = "<------->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label10.Location = new System.Drawing.Point(648, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 27);
            this.label10.TabIndex = 45;
            this.label10.Text = "Product buy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.label11.Location = new System.Drawing.Point(522, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 27);
            this.label11.TabIndex = 46;
            this.label11.Text = "Product loaned:\r\n";
            // 
            // LbProductLoaned
            // 
            this.LbProductLoaned.AutoSize = true;
            this.LbProductLoaned.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbProductLoaned.Location = new System.Drawing.Point(669, 371);
            this.LbProductLoaned.Name = "LbProductLoaned";
            this.LbProductLoaned.Size = new System.Drawing.Size(80, 27);
            this.LbProductLoaned.TabIndex = 47;
            this.LbProductLoaned.Text = "<------->";
            // 
            // LbBuy
            // 
            this.LbBuy.AutoSize = true;
            this.LbBuy.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.LbBuy.Location = new System.Drawing.Point(786, 327);
            this.LbBuy.Name = "LbBuy";
            this.LbBuy.Size = new System.Drawing.Size(80, 27);
            this.LbBuy.TabIndex = 48;
            this.LbBuy.Text = "<------->";
            // 
            // LbVisitorHistory
            // 
            this.LbVisitorHistory.FormattingEnabled = true;
            this.LbVisitorHistory.ItemHeight = 16;
            this.LbVisitorHistory.Location = new System.Drawing.Point(453, 424);
            this.LbVisitorHistory.Name = "LbVisitorHistory";
            this.LbVisitorHistory.Size = new System.Drawing.Size(401, 196);
            this.LbVisitorHistory.TabIndex = 49;
            // 
            // tBUserId
            // 
            this.tBUserId.Location = new System.Drawing.Point(662, 135);
            this.tBUserId.Name = "tBUserId";
            this.tBUserId.Size = new System.Drawing.Size(100, 22);
            this.tBUserId.TabIndex = 50;
            // 
            // timerVisitor
            // 
            this.timerVisitor.Interval = 10000;
            this.timerVisitor.Tick += new System.EventHandler(this.timerVisitor_Tick);
            // 
            // LbLoaned
            // 
            this.LbLoaned.FormattingEnabled = true;
            this.LbLoaned.ItemHeight = 16;
            this.LbLoaned.Location = new System.Drawing.Point(12, 380);
            this.LbLoaned.Name = "LbLoaned";
            this.LbLoaned.Size = new System.Drawing.Size(376, 244);
            this.LbLoaned.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Visitor who bought a product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Visitor who loaned a product";
            // 
            // VisitorInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(878, 640);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbLoaned);
            this.Controls.Add(this.tBUserId);
            this.Controls.Add(this.LbVisitorHistory);
            this.Controls.Add(this.LbBuy);
            this.Controls.Add(this.LbProductLoaned);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LbBalance);
            this.Controls.Add(this.LbFirstName);
            this.Controls.Add(this.LbLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbCampingStatus);
            this.Controls.Add(this.LbEvenstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.lbInfoBought);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitorInformation";
            this.Text = "Visitor Information";
            this.Load += new System.EventHandler(this.VisitorInformation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbInfoBought;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbCampingStatus;
        private System.Windows.Forms.Label LbEvenstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbFirstName;
        private System.Windows.Forms.Label LbLastName;
        private System.Windows.Forms.Label LbBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbProductLoaned;
        private System.Windows.Forms.Label LbBuy;
        private System.Windows.Forms.ListBox LbVisitorHistory;
        private System.Windows.Forms.TextBox tBUserId;
        private System.Windows.Forms.Timer timerVisitor;
        private System.Windows.Forms.ListBox LbLoaned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}