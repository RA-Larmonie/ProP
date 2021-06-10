namespace Food_Shop_Drinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btBuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.btBavaria = new System.Windows.Forms.Button();
            this.btHeiniken = new System.Windows.Forms.Button();
            this.btCocaCola = new System.Windows.Forms.Button();
            this.btFuzeTea = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(535, 28);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbTotal);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(9, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 494);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "The Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(226, 435);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 394);
            this.listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.btBuy);
            this.panel3.Location = new System.Drawing.Point(429, 506);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 94);
            this.panel3.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(2, 49);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(217, 43);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(2, 3);
            this.btBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(217, 43);
            this.btBuy.TabIndex = 32;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 492);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // btBavaria
            // 
            this.btBavaria.Location = new System.Drawing.Point(429, 106);
            this.btBavaria.Name = "btBavaria";
            this.btBavaria.Size = new System.Drawing.Size(189, 79);
            this.btBavaria.TabIndex = 34;
            this.btBavaria.Text = "BAVARIA";
            this.btBavaria.UseVisualStyleBackColor = true;
            this.btBavaria.Click += new System.EventHandler(this.btBavaria_Click);
            // 
            // btHeiniken
            // 
            this.btHeiniken.Location = new System.Drawing.Point(650, 203);
            this.btHeiniken.Name = "btHeiniken";
            this.btHeiniken.Size = new System.Drawing.Size(189, 79);
            this.btHeiniken.TabIndex = 35;
            this.btHeiniken.Text = "HEINIKEN";
            this.btHeiniken.UseVisualStyleBackColor = true;
            this.btHeiniken.Click += new System.EventHandler(this.btHeiniken_Click);
            // 
            // btCocaCola
            // 
            this.btCocaCola.Location = new System.Drawing.Point(429, 203);
            this.btCocaCola.Name = "btCocaCola";
            this.btCocaCola.Size = new System.Drawing.Size(189, 79);
            this.btCocaCola.TabIndex = 36;
            this.btCocaCola.Text = "COCA COLA";
            this.btCocaCola.UseVisualStyleBackColor = true;
            this.btCocaCola.Click += new System.EventHandler(this.btCocaCola_Click);
            // 
            // btFuzeTea
            // 
            this.btFuzeTea.Location = new System.Drawing.Point(650, 106);
            this.btFuzeTea.Name = "btFuzeTea";
            this.btFuzeTea.Size = new System.Drawing.Size(189, 79);
            this.btFuzeTea.TabIndex = 37;
            this.btFuzeTea.Text = "FUZE TEA";
            this.btFuzeTea.UseVisualStyleBackColor = true;
            this.btFuzeTea.Click += new System.EventHandler(this.btFuzeTea_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 611);
            this.Controls.Add(this.btFuzeTea);
            this.Controls.Add(this.btCocaCola);
            this.Controls.Add(this.btHeiniken);
            this.Controls.Add(this.btBavaria);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Drinks shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btBavaria;
        private System.Windows.Forms.Button btHeiniken;
        private System.Windows.Forms.Button btCocaCola;
        private System.Windows.Forms.Button btFuzeTea;
        private System.Windows.Forms.Timer timer1;
    }
}

