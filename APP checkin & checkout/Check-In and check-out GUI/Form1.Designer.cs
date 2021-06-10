namespace Check_In_and_check_out_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plCheckOut = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plCheckIn = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tbTicketNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCheckedIn = new System.Windows.Forms.RadioButton();
            this.rbCheckedOut = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plCheckOut.SuspendLayout();
            this.plCheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Check_In_and_check_out_GUI.Properties.Resources.no_back;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plCheckOut
            // 
            this.plCheckOut.BackColor = System.Drawing.Color.AliceBlue;
            this.plCheckOut.Controls.Add(this.label9);
            this.plCheckOut.Controls.Add(this.button1);
            this.plCheckOut.Controls.Add(this.textBox1);
            this.plCheckOut.Controls.Add(this.label2);
            this.plCheckOut.Controls.Add(this.label1);
            this.plCheckOut.Location = new System.Drawing.Point(12, 315);
            this.plCheckOut.Name = "plCheckOut";
            this.plCheckOut.Size = new System.Drawing.Size(589, 243);
            this.plCheckOut.TabIndex = 1;
            this.plCheckOut.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-out using RFID";
            // 
            // plCheckIn
            // 
            this.plCheckIn.BackColor = System.Drawing.Color.AliceBlue;
            this.plCheckIn.Controls.Add(this.label8);
            this.plCheckIn.Controls.Add(this.button3);
            this.plCheckIn.Controls.Add(this.tbTicketNo);
            this.plCheckIn.Controls.Add(this.label3);
            this.plCheckIn.Controls.Add(this.label4);
            this.plCheckIn.Location = new System.Drawing.Point(-3, 56);
            this.plCheckIn.Name = "plCheckIn";
            this.plCheckIn.Size = new System.Drawing.Size(589, 243);
            this.plCheckIn.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 57);
            this.button3.TabIndex = 6;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbTicketNo
            // 
            this.tbTicketNo.Location = new System.Drawing.Point(211, 132);
            this.tbTicketNo.Name = "tbTicketNo";
            this.tbTicketNo.Size = new System.Drawing.Size(162, 22);
            this.tbTicketNo.TabIndex = 2;
            this.tbTicketNo.TextChanged += new System.EventHandler(this.tbTicketNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "RFID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check-in using RFID";
            // 
            // rbCheckedIn
            // 
            this.rbCheckedIn.AutoSize = true;
            this.rbCheckedIn.Checked = true;
            this.rbCheckedIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.rbCheckedIn.Location = new System.Drawing.Point(12, 6);
            this.rbCheckedIn.Name = "rbCheckedIn";
            this.rbCheckedIn.Size = new System.Drawing.Size(90, 28);
            this.rbCheckedIn.TabIndex = 24;
            this.rbCheckedIn.TabStop = true;
            this.rbCheckedIn.Text = "Check-in";
            this.rbCheckedIn.UseVisualStyleBackColor = true;
            this.rbCheckedIn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbCheckedOut
            // 
            this.rbCheckedOut.AutoSize = true;
            this.rbCheckedOut.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.rbCheckedOut.Location = new System.Drawing.Point(118, 6);
            this.rbCheckedOut.Name = "rbCheckedOut";
            this.rbCheckedOut.Size = new System.Drawing.Size(99, 28);
            this.rbCheckedOut.TabIndex = 25;
            this.rbCheckedOut.Text = "Check-out";
            this.rbCheckedOut.UseVisualStyleBackColor = true;
            this.rbCheckedOut.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label5.Location = new System.Drawing.Point(643, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "RFID reader connection";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(676, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Not connected";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(645, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 57);
            this.button4.TabIndex = 28;
            this.button4.Text = "Change to minor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label7.Location = new System.Drawing.Point(640, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label8.Location = new System.Drawing.Point(75, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Visitor checked-in successfully";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.label9.Location = new System.Drawing.Point(75, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Visitor checked-out successfully";
            this.label9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(866, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.plCheckOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plCheckIn);
            this.Controls.Add(this.rbCheckedOut);
            this.Controls.Add(this.rbCheckedIn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EventIT Check-in and check-out application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plCheckOut.ResumeLayout(false);
            this.plCheckOut.PerformLayout();
            this.plCheckIn.ResumeLayout(false);
            this.plCheckIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plCheckOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plCheckIn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbTicketNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCheckedIn;
        private System.Windows.Forms.RadioButton rbCheckedOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

