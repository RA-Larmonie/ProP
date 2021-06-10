namespace Loan_Stand
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btLoan = new System.Windows.Forms.Button();
            this.btSlbg = new System.Windows.Forms.Button();
            this.btFlashLight = new System.Windows.Forms.Button();
            this.btCampTable = new System.Windows.Forms.Button();
            this.btCharger = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 406);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 57);
            this.panel2.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(324, 19);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(375, 20);
            this.tbID.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = " Ticket number or RFID ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 458);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btReturn);
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.btLoan);
            this.panel3.Location = new System.Drawing.Point(311, 409);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 145);
            this.panel3.TabIndex = 33;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(2, 97);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(217, 43);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLoan
            // 
            this.btLoan.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoan.Location = new System.Drawing.Point(2, 3);
            this.btLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btLoan.Name = "btLoan";
            this.btLoan.Size = new System.Drawing.Size(217, 43);
            this.btLoan.TabIndex = 32;
            this.btLoan.Text = "LOAN";
            this.btLoan.UseVisualStyleBackColor = true;
            this.btLoan.Click += new System.EventHandler(this.btLoan_Click);
            // 
            // btSlbg
            // 
            this.btSlbg.Location = new System.Drawing.Point(532, 97);
            this.btSlbg.Name = "btSlbg";
            this.btSlbg.Size = new System.Drawing.Size(189, 79);
            this.btSlbg.TabIndex = 41;
            this.btSlbg.Text = "SLEEPING BAG";
            this.btSlbg.UseVisualStyleBackColor = true;
            this.btSlbg.Click += new System.EventHandler(this.btSlbg_Click);
            // 
            // btFlashLight
            // 
            this.btFlashLight.Location = new System.Drawing.Point(311, 194);
            this.btFlashLight.Name = "btFlashLight";
            this.btFlashLight.Size = new System.Drawing.Size(189, 79);
            this.btFlashLight.TabIndex = 40;
            this.btFlashLight.Text = "FLASHLIGHT\r\n";
            this.btFlashLight.UseVisualStyleBackColor = true;
            this.btFlashLight.Click += new System.EventHandler(this.btFlashLight_Click);
            // 
            // btCampTable
            // 
            this.btCampTable.Location = new System.Drawing.Point(532, 194);
            this.btCampTable.Name = "btCampTable";
            this.btCampTable.Size = new System.Drawing.Size(189, 79);
            this.btCampTable.TabIndex = 39;
            this.btCampTable.Text = "CAMPING TABLE";
            this.btCampTable.UseVisualStyleBackColor = true;
            this.btCampTable.Click += new System.EventHandler(this.btCampTable_Click);
            // 
            // btCharger
            // 
            this.btCharger.Location = new System.Drawing.Point(311, 97);
            this.btCharger.Name = "btCharger";
            this.btCharger.Size = new System.Drawing.Size(189, 79);
            this.btCharger.TabIndex = 38;
            this.btCharger.Text = "CHARGER";
            this.btCharger.UseVisualStyleBackColor = true;
            this.btCharger.Click += new System.EventHandler(this.btCharger_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "The Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(170, 424);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 3;
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(2, 51);
            this.btReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(217, 43);
            this.btReturn.TabIndex = 34;
            this.btReturn.Text = "RETURN";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 381);
            this.listBox1.TabIndex = 5;
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(311, 323);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(79, 17);
            this.rbDamaged.TabIndex = 42;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "DAMAGED";
            this.rbDamaged.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(532, 323);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 17);
            this.radioButton1.TabIndex = 43;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NOT DAMAGED";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(741, 566);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbDamaged);
            this.Controls.Add(this.btSlbg);
            this.Controls.Add(this.btFlashLight);
            this.Controls.Add(this.btCampTable);
            this.Controls.Add(this.btCharger);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Loan Stand";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLoan;
        private System.Windows.Forms.Button btSlbg;
        private System.Windows.Forms.Button btFlashLight;
        private System.Windows.Forms.Button btCampTable;
        private System.Windows.Forms.Button btCharger;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

