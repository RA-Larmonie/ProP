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
using Phidget22;
using Phidget22.Events;

namespace Loan_Stand
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private RFID myRFIDReader;

        List<string> loan = new List<string>();
        List<decimal> priceLoan = new List<decimal>();
        List<int> idLoan = new List<int>();
        List<string> nameLoan = new List<string>();

        private DataHelper dh;
        List<Shop> cartList;
        List<Products> LoanProductList;
        private user user;

        private decimal actualTotal = 0;
        private int userID = 0;
        private string userRFID = "";

        public Form1()
        {
            InitializeComponent();
            dh = new DataHelper();
            cartList = new List<Shop>();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            
            StartPosition = FormStartPosition.CenterScreen;

            connection = new MySqlConnection("server=studmysql01.fhict.local;" +
                                                          "database=dbi393800;" +
                                                          "user id=dbi393800;" +
                                                           "password=ralia12345;");

            myRFIDReader = new RFID();

            try
            {
                myRFIDReader = new RFID();
                myRFIDReader.Tag += new RFIDTagEventHandler(this.ProcessThisTag);
                myRFIDReader.Open();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCharger_Click(object sender, EventArgs e)
        {
            ProductToLoan("charger");
            UpdateListbox();
            UpdateLoanList();
        }

        private void btSlbg_Click(object sender, EventArgs e)
        {
            ProductToLoan("sleepingbag");
            UpdateListbox();
            UpdateLoanList();
        }

        private void btFlashLight_Click(object sender, EventArgs e)
        {
            ProductToLoan("flaslight");
            UpdateListbox();
            UpdateLoanList();
        }

        private void btCampTable_Click(object sender, EventArgs e)
        {
            ProductToLoan("CampingTable");
            UpdateListbox();
            UpdateLoanList();
        }

        private void btLoan_Click(object sender, EventArgs e)
        {
            userRFID = tbID.Text;
            userID = GetUserID();
            if (userRFID == "")
            {
                MessageBox.Show("Please scan the visitors ID");
            }
            else
            {
                if (GetClientBalance() >= actualTotal)
                {
                    UpdateClientsBalance();
                    SetLoaned();
                    MessageBox.Show("Loaned succesfull");
                    listBox1.Items.Clear();
                    loan.Clear();
                    nameLoan.Clear();
                    priceLoan.Clear();
                    idLoan.Clear();
                    actualTotal = 0;
                    tbTotal.Clear();
                    tbID.Clear();
                }
                else
                {
                    MessageBox.Show("Insufficient funds");
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            loan.Clear();
            priceLoan.Clear();
            nameLoan.Clear();
            idLoan.Clear();
            actualTotal = 0;
            tbTotal.Clear();
            tbID.Clear();
            listBox1.Items.Clear();
        }

        private void ProcessThisTag(object sender, RFIDTagEventArgs e)
        {
            try
            {
                tbID.Text = e.Tag;
            }
            catch (PhidgetException pe)
            {
                MessageBox.Show(pe.Message);
            }
        }

        private int GetUserID()
        {
            string sqlGetUserID = $"SELECT UserID FROM visitor WHERE rfidID = '{userRFID}';";
            connection.Open();
            MySqlCommand getUserIDcommand = new MySqlCommand(sqlGetUserID, connection);
            MySqlDataReader getUserIDreader = getUserIDcommand.ExecuteReader();
            while (getUserIDreader.Read())
            {
                userID = Convert.ToInt32(getUserIDreader["UserID"]);
            }
            getUserIDreader.Close();
            connection.Close();

            return userID;
        }

        private void ProductToLoan(string name)
        {
            string product = "";

            string sqlProductName = $"SELECT ProductName FROM products WHERE ProductName = '{name}';";
            string sqlProductPrice = $"SELECT Price FROM products WHERE ProductName = '{name}' ORDER BY ProductID ASC LIMIT 1;";
            string sqlProdID = $"SELECT ProductID FROM products WHERE ProductName = '{name}' AND IsLoaned = '0' ORDER BY ProductID ASC LIMIT 1;";

            connection.Open();
            MySqlCommand productNameCommand = new MySqlCommand(sqlProductName, connection);
            MySqlDataReader productNameReader = productNameCommand.ExecuteReader();

            while (productNameReader.Read())
            {
                product = productNameReader[0].ToString() + "\t price: ";
                nameLoan.Add(productNameReader["ProductName"].ToString());
            }
            connection.Close();

            connection.Open();
            MySqlCommand productPriceCommand = new MySqlCommand(sqlProductPrice, connection);
            MySqlDataReader productPriceReader = productPriceCommand.ExecuteReader();

            while (productPriceReader.Read())
            {
                product += Convert.ToDecimal(productPriceReader["Price"]);
                priceLoan.Add(Convert.ToDecimal(productPriceReader["Price"]));
            }
            connection.Close();

            connection.Open();
            MySqlCommand productIDCommand = new MySqlCommand(sqlProdID, connection);
            MySqlDataReader productIDReader = productIDCommand.ExecuteReader();

            while (productIDReader.Read())
            {
                idLoan.Add(Convert.ToInt16(productIDReader["ProductID"]));
            }
            connection.Close();

            loan.Add(product);

        }

        private void UpdateListbox()
        {
            listBox1.Items.Clear();
            foreach (string item in loan)
            {
                listBox1.Items.Add(item);
            }
        }

        private void UpdateLoanList()
        {
            decimal total = 0;
            foreach (decimal item in priceLoan)
            {
                total += item;
            }
            actualTotal = total;
            tbTotal.Text = actualTotal.ToString();
        }

        private decimal GetClientBalance()
        {
            decimal clientBalance = 0;
            string sqlGetVisitorsID = $"SELECT Balance FROM visitor WHERE rfidID = '{userRFID}'";

            connection.Open();
            MySqlCommand visitorBalanceCommand = new MySqlCommand(sqlGetVisitorsID, connection);
            MySqlDataReader visitorBalanceReader = visitorBalanceCommand.ExecuteReader();

            while (visitorBalanceReader.Read())
            {
                clientBalance = Convert.ToDecimal(visitorBalanceReader["Balance"]);
            }
            connection.Close();
            return clientBalance;
        }

        private void UpdateClientsBalance()
        {
            decimal clientBalance = GetClientBalance();
            decimal newBalance = clientBalance - actualTotal;

            string sqlUpdateBalance = $"UPDATE visitor SET Balance = '{newBalance}' WHERE rfidID = '{userRFID}';";
            connection.Open();
            MySqlCommand updateBalanceCommand = new MySqlCommand(sqlUpdateBalance, connection);
            updateBalanceCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void SetLoaned()
        {
            int userID = GetUserID();
            string name = "";

            foreach (int item in idLoan)
            {
                string sqlUpdateIsLoaned = $"UPDATE products SET IsLoaned = '1' WHERE ProductID = {item};";
                MySqlCommand updateLoanCommand = new MySqlCommand(sqlUpdateIsLoaned, connection);
                connection.Open();
                updateLoanCommand.ExecuteNonQuery();
                connection.Close();

                connection.Open();
                string sqlProdName = $"SELECT ProductName FROM products WHERE ProductID = {item};";
                MySqlCommand transactionNameCommand = new MySqlCommand(sqlProdName, connection);
                MySqlDataReader transactionNameReader = transactionNameCommand.ExecuteReader();

                while (transactionNameReader.Read())
                {
                    name = Convert.ToString(transactionNameReader["ProductName"]);
                }
                connection.Close();

                string sqlInsertLoaned = $"INSERT INTO loanproduct (ProductID, UserID, rfidID, LoanDate, ProductName) VALUES ({item}, {userID}, '{userRFID}', CURRENT_TIMESTAMP, '{name}');";
                MySqlCommand insertLoanCommand = new MySqlCommand(sqlInsertLoaned, connection);
                connection.Open();
                insertLoanCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void SetReturned()
        {
            int userID = GetUserID();
            int transID = 0;
            int prodID = 0;

            foreach (string item in nameLoan)
            {
                string sqlTransID = $"SELECT TransactionID FROM loanproduct WHERE UserID = {userID} AND ProductName = '{item}' ORDER BY TransactionID DESC LIMIT 1;";
                connection.Open();
                MySqlCommand transactionIDCommand = new MySqlCommand(sqlTransID, connection);
                MySqlDataReader transactionIDReader = transactionIDCommand.ExecuteReader();

                while (transactionIDReader.Read())
                {
                    transID = Convert.ToInt32(transactionIDReader["TransactionID"]);
                }
                connection.Close();

                string sqlprodID = $"SELECT ProductID FROM loanproduct WHERE UserID = {userID} AND TransactionID = '{transID}' ORDER BY ProductID DESC LIMIT 1;";
                connection.Open();
                MySqlCommand prodIDCommand = new MySqlCommand(sqlprodID, connection);
                MySqlDataReader prodIDReader = prodIDCommand.ExecuteReader();

                while (prodIDReader.Read())
                {
                    prodID = Convert.ToInt32(prodIDReader["ProductID"]);
                }
                connection.Close();

                string sqlUpdateReturn = $"UPDATE products SET IsLoaned = '0' WHERE ProductID = {prodID};";
                MySqlCommand updateLoanCommand = new MySqlCommand(sqlUpdateReturn, connection);
                connection.Open();
                updateLoanCommand.ExecuteNonQuery();
                connection.Close();

                if (rbDamaged.Checked)
                {
                    string sqlUpdateDamaged = $"UPDATE loanproduct SET IsDamaged = '1' WHERE TransactionID = {transID};";
                    MySqlCommand updateDamagedCommand = new MySqlCommand(sqlUpdateDamaged, connection);
                    connection.Open();
                    updateDamagedCommand.ExecuteNonQuery();
                    connection.Close();

                    string sqlUpdateReturnTime = $"UPDATE loanproduct SET ReturnDate = CURRENT_TIMESTAMP WHERE TransactionID = {transID};";
                    MySqlCommand updateLoanTimeCommand = new MySqlCommand(sqlUpdateReturnTime, connection);
                    connection.Open();
                    updateLoanTimeCommand.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    string sqlUpdateReturnTime = $"UPDATE loanproduct SET ReturnDate = CURRENT_TIMESTAMP WHERE TransactionID = {transID};";
                    MySqlCommand updateLoanTimeCommand = new MySqlCommand(sqlUpdateReturnTime, connection);
                    connection.Open();
                    updateLoanTimeCommand.ExecuteNonQuery();
                    connection.Close();

                    //MessageBox.Show("transID: " + transID + "   prodID: " + prodID + "    userID: " + userID + "   name: " + item);
                }
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            userRFID = tbID.Text;
            userID = GetUserID();
            if (userRFID == "")
            {
                MessageBox.Show("Please scan the visitors ID");
            }
            else
            {
                    SetReturned();
                    MessageBox.Show("Return succesfull");
                    listBox1.Items.Clear();
                    loan.Clear();
                    idLoan.Clear();
                    nameLoan.Clear();
                    priceLoan.Clear();
                    actualTotal = 0;
                    tbTotal.Clear();
                    tbID.Clear();
            }
        }
    }
}
