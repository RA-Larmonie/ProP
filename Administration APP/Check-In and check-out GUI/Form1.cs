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
    public partial class Form1 : Form
    {
        static VisitorInformation visitorInfo = new VisitorInformation();
        static CampingInformation campingInfo = new CampingInformation();
        static AddProducts addProducts = new AddProducts();
        static ItemsInformationcs iteminformation = new ItemsInformationcs();
        SQLDataControl sqlControl;

        public Form1()
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
                sqlControl = new SQLDataControl();
                MessageBox.Show("Connection successful");
                
               
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            GeneralTimer.Start();
        

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            visitorInfo.Show();
        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            campingInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addProducts.Show();
        }
        private void Start()
        {
            try
            {
                tBAmountVisitor.Text = Convert.ToString(sqlControl.GetAllVisitors());
                tBAvailableCamping.Text = Convert.ToString(sqlControl.NumberOfAvailableCampingSpots());
                tBItemsLoaned.Text = Convert.ToString(sqlControl.GetAllNumberOfLoanedProducts());
                tBProductSold.Text = Convert.ToString(sqlControl.GetAllNumberOfSoldProducts());
                tBNumberTicketSold.Text = Convert.ToString(sqlControl.GetNumberOfTicketSold());
                tBProfitRenterItems.Text = Convert.ToString(sqlControl.GetProfitLoan());
                tBprofitSoldItems.Text = Convert.ToString(sqlControl.GetProductsProfit());
                tBProfitTicket.Text = Convert.ToString(sqlControl.GetEventTicketProfit());
                tBTotalProfit.Text = Convert.ToString(sqlControl.GetTotalProfit());
                tBCheckedIn.Text = Convert.ToString(sqlControl.GetVisitorCheckedInEvent());
                tBCheckout.Text = Convert.ToString(sqlControl.GetVisitorCheckedOutEvent());


            }
            catch(MySqlException )
            {
                MessageBox.Show("Connection problem");
            }
            catch(FormatException)
            {
                MessageBox.Show("Format Exception");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Database is empty");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void GeneralTimer_Tick(object sender, EventArgs e)
        {
            Start();
        }

        private void btnItemInfo_Click(object sender, EventArgs e)
        {
            try
            {
                iteminformation.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
