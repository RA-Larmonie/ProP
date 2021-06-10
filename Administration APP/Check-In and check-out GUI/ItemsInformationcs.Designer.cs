namespace Check_In_and_check_out_GUI
{
    partial class ItemsInformationcs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbInfoReturned = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInStock = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.lblAmountEarned = new System.Windows.Forms.Label();
            this.lblAmountSold = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckSold = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLoanInStock = new System.Windows.Forms.Label();
            this.btnLoanItemCheck = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLoanProducts = new System.Windows.Forms.ComboBox();
            this.lblLoanEaerned = new System.Windows.Forms.Label();
            this.lblLoanSold = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbNotReturned = new System.Windows.Forms.ListBox();
            this.ItemTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(257, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(244, 46);
            this.label18.TabIndex = 18;
            this.label18.Text = "Items information";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Location = new System.Drawing.Point(1, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 23);
            this.panel3.TabIndex = 23;
            // 
            // LbInfoReturned
            // 
            this.LbInfoReturned.FormattingEnabled = true;
            this.LbInfoReturned.ItemHeight = 16;
            this.LbInfoReturned.Location = new System.Drawing.Point(12, 150);
            this.LbInfoReturned.Name = "LbInfoReturned";
            this.LbInfoReturned.Size = new System.Drawing.Size(383, 148);
            this.LbInfoReturned.TabIndex = 36;
            this.LbInfoReturned.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.lblInStock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbProducts);
            this.groupBox1.Controls.Add(this.lblAmountEarned);
            this.groupBox1.Controls.Add(this.lblAmountSold);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(415, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 210);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sold Items";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.Location = new System.Drawing.Point(245, 93);
            this.lblInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(37, 24);
            this.lblInStock.TabIndex = 13;
            this.lblInStock.Text = "NR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(53, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "In Stock:";
            // 
            // cbProducts
            // 
            this.cbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(80, 39);
            this.cbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(155, 28);
            this.cbProducts.TabIndex = 11;
            this.cbProducts.Text = "Items";
            // 
            // lblAmountEarned
            // 
            this.lblAmountEarned.AutoSize = true;
            this.lblAmountEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountEarned.Location = new System.Drawing.Point(245, 162);
            this.lblAmountEarned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountEarned.Name = "lblAmountEarned";
            this.lblAmountEarned.Size = new System.Drawing.Size(37, 24);
            this.lblAmountEarned.TabIndex = 8;
            this.lblAmountEarned.Text = "NR";
            // 
            // lblAmountSold
            // 
            this.lblAmountSold.AutoSize = true;
            this.lblAmountSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountSold.Location = new System.Drawing.Point(245, 128);
            this.lblAmountSold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountSold.Name = "lblAmountSold";
            this.lblAmountSold.Size = new System.Drawing.Size(37, 24);
            this.lblAmountSold.TabIndex = 7;
            this.lblAmountSold.Text = "NR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount sold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item: ";
            // 
            // btnCheckSold
            // 
            this.btnCheckSold.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSold.Location = new System.Drawing.Point(656, 130);
            this.btnCheckSold.Name = "btnCheckSold";
            this.btnCheckSold.Size = new System.Drawing.Size(112, 44);
            this.btnCheckSold.TabIndex = 38;
            this.btnCheckSold.Text = "Check";
            this.btnCheckSold.UseVisualStyleBackColor = true;
            this.btnCheckSold.Click += new System.EventHandler(this.btnCheckSold_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox2.Controls.Add(this.lblLoanInStock);
            this.groupBox2.Controls.Add(this.btnLoanItemCheck);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbLoanProducts);
            this.groupBox2.Controls.Add(this.lblLoanEaerned);
            this.groupBox2.Controls.Add(this.lblLoanSold);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(415, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(373, 210);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Items";
            // 
            // lblLoanInStock
            // 
            this.lblLoanInStock.AutoSize = true;
            this.lblLoanInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanInStock.Location = new System.Drawing.Point(245, 96);
            this.lblLoanInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanInStock.Name = "lblLoanInStock";
            this.lblLoanInStock.Size = new System.Drawing.Size(37, 24);
            this.lblLoanInStock.TabIndex = 15;
            this.lblLoanInStock.Text = "NR";
            // 
            // btnLoanItemCheck
            // 
            this.btnLoanItemCheck.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanItemCheck.Location = new System.Drawing.Point(241, 31);
            this.btnLoanItemCheck.Name = "btnLoanItemCheck";
            this.btnLoanItemCheck.Size = new System.Drawing.Size(112, 44);
            this.btnLoanItemCheck.TabIndex = 39;
            this.btnLoanItemCheck.Text = "Check";
            this.btnLoanItemCheck.UseVisualStyleBackColor = true;
            this.btnLoanItemCheck.Click += new System.EventHandler(this.btnLoanItemCheck_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(53, 96);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "In Stock:";
            // 
            // cbLoanProducts
            // 
            this.cbLoanProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoanProducts.FormattingEnabled = true;
            this.cbLoanProducts.Location = new System.Drawing.Point(80, 39);
            this.cbLoanProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoanProducts.Name = "cbLoanProducts";
            this.cbLoanProducts.Size = new System.Drawing.Size(155, 28);
            this.cbLoanProducts.TabIndex = 11;
            this.cbLoanProducts.Text = "Items";
            // 
            // lblLoanEaerned
            // 
            this.lblLoanEaerned.AutoSize = true;
            this.lblLoanEaerned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanEaerned.Location = new System.Drawing.Point(245, 171);
            this.lblLoanEaerned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanEaerned.Name = "lblLoanEaerned";
            this.lblLoanEaerned.Size = new System.Drawing.Size(37, 24);
            this.lblLoanEaerned.TabIndex = 8;
            this.lblLoanEaerned.Text = "NR";
            // 
            // lblLoanSold
            // 
            this.lblLoanSold.AutoSize = true;
            this.lblLoanSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanSold.Location = new System.Drawing.Point(245, 136);
            this.lblLoanSold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanSold.Name = "lblLoanSold";
            this.lblLoanSold.Size = new System.Drawing.Size(37, 24);
            this.lblLoanSold.TabIndex = 7;
            this.lblLoanSold.Text = "NR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(53, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Profit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Amount sold:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Item: ";
            // 
            // LbNotReturned
            // 
            this.LbNotReturned.FormattingEnabled = true;
            this.LbNotReturned.ItemHeight = 16;
            this.LbNotReturned.Location = new System.Drawing.Point(12, 365);
            this.LbNotReturned.Name = "LbNotReturned";
            this.LbNotReturned.Size = new System.Drawing.Size(383, 148);
            this.LbNotReturned.TabIndex = 39;
            // 
            // ItemTimer
            // 
            this.ItemTimer.Interval = 10000;
            this.ItemTimer.Tick += new System.EventHandler(this.ItemTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Visitor who returned to product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Visitor who not returned to product";
            // 
            // ItemsInformationcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbNotReturned);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCheckSold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbInfoReturned);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ItemsInformationcs";
            this.Text = "ItemsInformationcs";
            this.Load += new System.EventHandler(this.ItemsInformationcs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox LbInfoReturned;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lblAmountEarned;
        private System.Windows.Forms.Label lblAmountSold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckSold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoanItemCheck;
        private System.Windows.Forms.ComboBox cbLoanProducts;
        private System.Windows.Forms.Label lblLoanEaerned;
        private System.Windows.Forms.Label lblLoanSold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLoanInStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox LbNotReturned;
        private System.Windows.Forms.Timer ItemTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}