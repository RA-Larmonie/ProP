using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Check_In_and_check_out_GUI
{
    public partial class AddProducts : Form
    {

        SQLDataControl SqlAddProduct;

        public AddProducts()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            //MinimizeBox = false;

            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

           
            
            try
            {
                SqlAddProduct = new SQLDataControl();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Database connection problem");
            }
            foreach (string productType in SqlAddProduct.GetBuyProducts())
            {
                cBProductName.Items.Add(productType).ToString();
            }
            tBPrice.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
             
                string ProductName = cBProductName.SelectedItem.ToString();            
                
                

                
                if (cBLoanProduct.Checked)
                {
                    decimal price = Convert.ToDecimal(tBPrice.Text);
                    SqlAddProduct.AddLoanProduct(ProductName, price);
                }
                else
                {
                    int ProductAmount = Convert.ToInt32(tBAmountProduct.Text);
                    SqlAddProduct.AddProductToStock(ProductName, ProductAmount);
                }



            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(MySqlException)
            {
                MessageBox.Show("Connection problem");
            }        
            catch (NullReferenceException)
            {
                MessageBox.Show("Please type the informations");
            }
            

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void cBLoanProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (cBLoanProduct.Checked == true)
            {
                tBAmountProduct.Enabled = false;
                tBPrice.Enabled = true;

                cBProductName.Items.Clear();
                foreach (string item in SqlAddProduct.GetLoanProducts())
                {
                    cBProductName.Items.Add(item);
                }
            }
            else
            {
                tBAmountProduct.Enabled = true;
                tBPrice.Enabled = false;
                cBProductName.Items.Clear();
                foreach (string productType in SqlAddProduct.GetBuyProducts())
                {
                    cBProductName.Items.Add(productType).ToString();
                }
            }
        }
    }
}
