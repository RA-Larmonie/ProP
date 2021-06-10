namespace Food_shop_souvenirs
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btBuy = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btKeychain = new System.Windows.Forms.Button();
            this.btShirt = new System.Windows.Forms.Button();
            this.btMug = new System.Windows.Forms.Button();
            this.btBandanna = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 492);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbTotal);
            this.panel2.Location = new System.Drawing.Point(9, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 494);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total Price:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(225, 441);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btBuy);
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Location = new System.Drawing.Point(429, 506);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 94);
            this.panel3.TabIndex = 4;
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(4, 50);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(217, 43);
            this.btBuy.TabIndex = 33;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(4, 2);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(217, 42);
            this.btCancel.TabIndex = 32;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 82);
            this.panel1.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(567, 28);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(239, 20);
            this.tbID.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = " Ticket number or QR-Code ";
            // 
            // btKeychain
            // 
            this.btKeychain.Location = new System.Drawing.Point(429, 106);
            this.btKeychain.Name = "btKeychain";
            this.btKeychain.Size = new System.Drawing.Size(189, 79);
            this.btKeychain.TabIndex = 6;
            this.btKeychain.Text = "KEYCHAIN";
            this.btKeychain.UseVisualStyleBackColor = true;
            this.btKeychain.Click += new System.EventHandler(this.btKeychain_Click);
            // 
            // btShirt
            // 
            this.btShirt.Location = new System.Drawing.Point(650, 203);
            this.btShirt.Name = "btShirt";
            this.btShirt.Size = new System.Drawing.Size(189, 79);
            this.btShirt.TabIndex = 7;
            this.btShirt.Text = "T-SHIRT";
            this.btShirt.UseVisualStyleBackColor = true;
            this.btShirt.Click += new System.EventHandler(this.btShirt_Click);
            // 
            // btMug
            // 
            this.btMug.Location = new System.Drawing.Point(429, 203);
            this.btMug.Name = "btMug";
            this.btMug.Size = new System.Drawing.Size(189, 79);
            this.btMug.TabIndex = 8;
            this.btMug.Text = "MUG";
            this.btMug.UseVisualStyleBackColor = true;
            this.btMug.Click += new System.EventHandler(this.btMug_Click);
            // 
            // btBandanna
            // 
            this.btBandanna.Location = new System.Drawing.Point(650, 106);
            this.btBandanna.Name = "btBandanna";
            this.btBandanna.Size = new System.Drawing.Size(189, 79);
            this.btBandanna.TabIndex = 9;
            this.btBandanna.Text = "BANDANNA";
            this.btBandanna.UseVisualStyleBackColor = true;
            this.btBandanna.Click += new System.EventHandler(this.btBandanna_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(688, 351);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(111, 64);
            this.btRemove.TabIndex = 33;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 394);
            this.listBox1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 611);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btBandanna);
            this.Controls.Add(this.btMug);
            this.Controls.Add(this.btShirt);
            this.Controls.Add(this.btKeychain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Souvenir shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btKeychain;
        private System.Windows.Forms.Button btShirt;
        private System.Windows.Forms.Button btMug;
        private System.Windows.Forms.Button btBandanna;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox listBox1;
    }
}

