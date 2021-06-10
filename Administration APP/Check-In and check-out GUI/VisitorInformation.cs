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
    public partial class VisitorInformation : Form
    {
        SQLDataControl sqlVisitorControl;
        public VisitorInformation()
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
                sqlVisitorControl = new SQLDataControl();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Database connection problem");
            }
            timerVisitor.Start();
        }

        private void VisitorInformation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(tBUserId.Text);

            try
            {
                LbEvenstatus.Text = sqlVisitorControl.GetVisitorEventStatus(UserID);
                LbFirstName.Text = sqlVisitorControl.GetVisitorFirstName(UserID);
                LbLastName.Text = sqlVisitorControl.GetVisitorLastName(UserID);
                LbBalance.Text = sqlVisitorControl.GetVisitorBalance(UserID);
                LbCampingStatus.Text = sqlVisitorControl.GetVisitorCampingStatus(UserID);
                LbBuy.Text = Convert.ToString(sqlVisitorControl.GetSpecificPersonNumberOfProduct(UserID));
                LbProductLoaned.Text =Convert.ToString( sqlVisitorControl.GetSpecificPersonNumberOfLoaned(UserID));

                LbVisitorHistory.Items.Clear();
                foreach (string item in sqlVisitorControl.GetProductSpecificUserBuy(UserID))
                {
                    LbVisitorHistory.Items.Add(item);
                }
                foreach (string item in sqlVisitorControl.GetProductSpecificUserLoaned(UserID))
                {
                    LbVisitorHistory.Items.Add(item);
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Please type User ID ");
            }
            catch(NullReferenceException )
            {
                MessageBox.Show("Please type User ID ");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Something went wrong");
            }
            catch (InvalidCastException)
            {
                LbVisitorHistory.Items.Clear();
                LbEvenstatus.Text = "";
                LbFirstName.Text = "";
                LbLastName.Text = "";
                LbBalance.Text = "";
                LbCampingStatus.Text = "";
                LbBuy.Text = "";
                LbProductLoaned.Text = ""; 
                MessageBox.Show("User didnt checked yet and dont have a Rfid");
                sqlVisitorControl.Disconnect();
                LbVisitorHistory.Items.Clear();
            }
           


        }
        private void StartUp()
        {
            lbInfoBought.Items.Clear();
            LbLoaned.Items.Clear();
            try
            {
                foreach (string item in sqlVisitorControl.GetAllProductBuyers())
                {
                    lbInfoBought.Items.Add(item);
                }

                foreach (string item in sqlVisitorControl.GetAllUserLoaned())
                {
                    LbLoaned.Items.Add(item);
                }
                
            }       
            catch (MySqlException)
            {
                MessageBox.Show("Database problem");
                sqlVisitorControl.Disconnect();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
                sqlVisitorControl.Disconnect();
            }
        }
        private void timerVisitor_Tick(object sender, EventArgs e)
        {

            StartUp();
        }
    }
}
