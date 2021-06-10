namespace Check_In_and_check_out_GUI
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.cBLoanProduct = new System.Windows.Forms.CheckBox();
            this.tBAmountProduct = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cBProductName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.button1.Location = new System.Drawing.Point(361, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBPrice);
            this.panel1.Controls.Add(this.cBLoanProduct);
            this.panel1.Controls.Add(this.tBAmountProduct);
            this.panel1.Controls.Add(this.btnProductAdd);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cBProductName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 314);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Price:";
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(175, 181);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(264, 22);
            this.tBPrice.TabIndex = 22;
            // 
            // cBLoanProduct
            // 
            this.cBLoanProduct.AutoSize = true;
            this.cBLoanProduct.Location = new System.Drawing.Point(175, 65);
            this.cBLoanProduct.Name = "cBLoanProduct";
            this.cBLoanProduct.Size = new System.Drawing.Size(115, 21);
            this.cBLoanProduct.TabIndex = 21;
            this.cBLoanProduct.Text = "Loan Product";
            this.cBLoanProduct.UseVisualStyleBackColor = true;
            this.cBLoanProduct.CheckedChanged += new System.EventHandler(this.cBLoanProduct_CheckedChanged);
            // 
            // tBAmountProduct
            // 
            this.tBAmountProduct.Location = new System.Drawing.Point(175, 143);
            this.tBAmountProduct.Name = "tBAmountProduct";
            this.tBAmountProduct.Size = new System.Drawing.Size(264, 22);
            this.tBAmountProduct.TabIndex = 20;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.8F);
            this.btnProductAdd.Location = new System.Drawing.Point(24, 226);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(415, 43);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Amount:";
            // 
            // cBProductName
            // 
            this.cBProductName.FormattingEnabled = true;
            this.cBProductName.Location = new System.Drawing.Point(175, 103);
            this.cBProductName.Name = "cBProductName";
            this.cBProductName.Size = new System.Drawing.Size(264, 24);
            this.cBProductName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label2.Location = new System.Drawing.Point(131, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Add product for sell ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 70);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 46);
            this.label9.TabIndex = 18;
            this.label9.Text = "Administration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Location = new System.Drawing.Point(2, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 23);
            this.panel3.TabIndex = 20;
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProducts";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.ComboBox cBProductName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tBAmountProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cBLoanProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPrice;
    }
}