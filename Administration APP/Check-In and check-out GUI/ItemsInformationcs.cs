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
    public partial class ItemsInformationcs : Form
    {
        SQLDataControl SQLItemsControl;
        public ItemsInformationcs()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog;

            MaximizeBox = false;

            StartPosition = FormStartPosition.CenterScreen;

            try
            {
                SQLItemsControl = new SQLDataControl();

            }
            catch(MySqlException)
            {
                MessageBox.Show("Database connection problem");
            }

            foreach (string productitem in SQLItemsControl.GetBuyProducts())
            {
                cbProducts.Items.Add(productitem).ToString();
            }
            foreach (string productitem in SQLItemsControl.GetLoanProducts())
            {
                cbLoanProducts.Items.Add(productitem).ToString();
            }
            ItemTimer.Start();

        }

        private void ItemsInformationcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

     

        private void btnCheckSold_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedItem = cbProducts.SelectedItem.ToString();
                int AmountSold = SQLItemsControl.GetSpecificProductAmount(SelectedItem);
                lblAmountSold.Text = AmountSold.ToString();

                int Price = SQLItemsControl.GetSpecificProductPrice(SelectedItem);

                int Profit = Price * AmountSold;

                lblAmountEarned.Text = Profit.ToString();

                int Instock = SQLItemsControl.GetAmountOfSpecificItem(SelectedItem);

                lblInStock.Text = Instock.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please choose product");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            
            
           
            
        }
        private void StartUp()
        {
            LbNotReturned.Items.Clear();
            LbInfoReturned.Items.Clear();
            try
            {
                foreach (string item in SQLItemsControl.GetProductLoanersReturned())
                {
                    LbInfoReturned.Items.Add(item).ToString();
                }

                foreach (string item in SQLItemsControl.GetProductLoanersNotReturned())
                {
                    LbNotReturned.Items.Add(item).ToString();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Database problem");
                SQLItemsControl.Disconnect();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
                SQLItemsControl.Disconnect();
            }


        }
        private void btnLoanItemCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectedItem = cbLoanProducts.SelectedItem.ToString();
                int AmountSold = SQLItemsControl.GetSpecificLoanAmount(SelectedItem);
                lblLoanSold.Text = AmountSold.ToString();

                int Price = SQLItemsControl.GetSpecificProductPrice(SelectedItem);

                int Profit = Price * AmountSold;

                lblLoanEaerned.Text = Profit.ToString();

                int Instock = SQLItemsControl.GetAmountOfSpecificLoanItem(SelectedItem);

                lblLoanInStock.Text = Instock.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please choose product");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void ItemTimer_Tick(object sender, EventArgs e)
        {
            StartUp();
            
        }
    }
}
