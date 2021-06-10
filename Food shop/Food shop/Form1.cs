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

namespace Food_shop
{
    public partial class Form1 : Form
    {
        #region FIELDS
        private RFID myRFIDReader;
        private MySqlConnection connection;

        List<string> purchase = new List<string>();
        List<decimal> pricePurchase = new List<decimal>();
        List<string> namePurchase = new List<string>();

        private decimal actualTotal = 0;
        private int userID = 0;
        private string userRFID = "";
        #endregion

        #region CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
            try
            {
                connection = new MySqlConnection("server=studmysql01.fhict.local;" +
                                                             "database=dbi393800;" +
                                                             "user id=dbi393800;" +
                                                              "password=ralia12345;");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        #endregion

        #region BUTTON FOR FOOD
        private void btHamburger_Click(object sender, EventArgs e)
        {
            ProductToBuy("HAMBURGER");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btFrikandel_Click(object sender, EventArgs e)
        {
            ProductToBuy("FRIKANDEL");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btCroquette_Click(object sender, EventArgs e)
        {
            ProductToBuy("CROQUETTES");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btHotdog_Click(object sender, EventArgs e)
        {
            ProductToBuy("HOTDOG");
            UpdateListbox();
            UpdatePurchaseList();
        }
        #endregion

        #region BUTTON PURCHASE PRODUCT
        private void btBuy_Click(object sender, EventArgs e)
        {
            userRFID = tbID.Text;
            userID = GetUserID();

            if (userRFID == "")
            {
                MessageBox.Show("Please scan the visitors ID");
            }
            else if (!CheckIfIDExist())
            {
                MessageBox.Show("This ID does not exist.");
                purchase.Clear();
                pricePurchase.Clear();
                namePurchase.Clear();
                actualTotal = 0;
                tbTotal.Clear();
                tbID.Clear();
                listBox1.Items.Clear();
                userID = 0;
                userRFID = "";
            }
            else if (userID == 0)
            {
                MessageBox.Show("Please scan the visitors ID");
            }
            else if (purchase.Count == 0)
            {
                MessageBox.Show("Please add item for purchase");
            }
            else
            {
                int hamburger = 0; int hamburgerAmount = AmountOfFoodAvailable("HAMBURGER"); bool _hamburger;
                int hotdog = 0; int hotdogAmount = AmountOfFoodAvailable("HOTDOG"); bool _hotdog;
                int frikandel = 0; int frikandelAmount = AmountOfFoodAvailable("FRIKANDEL"); bool _frikandel;
                int croquettes = 0; int croquetteAmount = AmountOfFoodAvailable("CROQUETTES"); bool _croquettes;

                foreach (string item in namePurchase)
                {
                    if (item == "HAMBURGER")
                    { hamburger++; }
                    else if (item == "FRIKANDEL")
                    { frikandel++; }
                    else if (item == "HOTDOG")
                    { hotdog++; }
                    else if (item == "CROQUETTES")
                    { croquettes++; }
                }


                if (hamburger >= 0 && hamburger < hamburgerAmount)
                { _hamburger = true; }
                else
                {
                    _hamburger = false;
                    MessageBox.Show($"There is {hamburgerAmount} hamburger available and you asked for {hamburger}");
                }
                if (hotdog >= 0 && hotdog < hotdogAmount)
                { _hotdog = true; }
                else
                {
                    _hotdog = false;
                    MessageBox.Show($"There is {hotdogAmount} hotdog available and you asked for {hotdog}");
                }
                if (frikandel >= 0 && frikandel < frikandelAmount)
                { _frikandel = true; }
                else
                {
                    _frikandel = false;
                    MessageBox.Show($"There is {frikandelAmount} frikandel available and you asked for {frikandel}");
                }
                if (croquettes >= 0 && croquettes < croquetteAmount)
                { _croquettes = true; }
                else
                {
                    _croquettes = false;
                    MessageBox.Show($"There is {croquetteAmount} croquettes available and you asked for {croquettes}");
                }

                //check if the register person has enough
                if (_hamburger && _hotdog && _frikandel && _croquettes)
                {
                    //MessageBox.Show("all the items came out alright");
                    if (GetClientBalance() >= actualTotal)
                    {
                        UpdateClientsBalance();
                        RemoveAmountFromProduct();
                        HandelTransactionForDB();
                        MessageBox.Show("Transaction succesfull");
                        listBox1.Items.Clear();
                        purchase.Clear();
                        namePurchase.Clear();
                        pricePurchase.Clear();
                        actualTotal = 0;
                        tbTotal.Clear();
                        tbID.Clear();
                        userID = 0;
                        userRFID = "";
                    }
                    else
                    {
                        MessageBox.Show("The client has an insufficient balance");
                        purchase.Clear();
                        pricePurchase.Clear();
                        namePurchase.Clear();
                        actualTotal = 0;
                        tbTotal.Clear();
                        tbID.Clear();
                        listBox1.Items.Clear();
                        userID = 0;
                        userRFID = "";
                    }
                }
            }
        }
        #endregion       

        #region BUTTON REMOVE ITEM
        private void btRemove_Click(object sender, EventArgs e)
        {
            RemoveFromPurchasing();
            UpdateListbox();
            UpdatePurchaseList();
        }
        #endregion

        #region BUTTON TO CANCEL PURCHASE
        private void btCancel_Click(object sender, EventArgs e)
        {
            purchase.Clear();
            pricePurchase.Clear();
            namePurchase.Clear();
            actualTotal = 0;
            tbTotal.Clear();
            tbID.Clear();
            userID = 0;
            userRFID = "";
            listBox1.Items.Clear();
        }
        #endregion

        #region METHODS
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

        private void ProductToBuy(string name)
        {
            string product = "";
            string sqlProductName = $"SELECT ProductName FROM products WHERE ProductName = '{name}';";
            string sqlProductPrice = $"SELECT Price FROM products WHERE ProductName = '{name}';";

            MySqlCommand productNameCommand = new MySqlCommand(sqlProductName, connection);
            try
            {
                connection.Open();
                MySqlDataReader productNameReader = productNameCommand.ExecuteReader();

                while (productNameReader.Read())
                {
                    product = productNameReader[0].ToString() + "\t";
                    namePurchase.Add(productNameReader["ProductName"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
            }
            finally
            {
                connection.Close();
            }

            MySqlCommand productPriceCommand = new MySqlCommand(sqlProductPrice, connection);
            try
            {
                connection.Open();
                MySqlDataReader productPriceReader = productPriceCommand.ExecuteReader();

                while (productPriceReader.Read())
                {
                    product += Convert.ToDecimal(productPriceReader["Price"]);
                    pricePurchase.Add(Convert.ToDecimal(productPriceReader["Price"]));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
            }
            finally
            {
                connection.Close();
            }            

            purchase.Add(product);
        }

        private void RemoveFromPurchasing()
        {
            int removeItemAtLocation = listBox1.SelectedIndex;
            purchase.RemoveAt(removeItemAtLocation);
            namePurchase.RemoveAt(removeItemAtLocation);
            pricePurchase.RemoveAt(removeItemAtLocation);
        }

        private void UpdateListbox()
        {
            listBox1.Items.Clear();
            foreach (string item in purchase)
            {
                listBox1.Items.Add(item);
            }
        }

        private void UpdatePurchaseList()
        {
            decimal total = 0;
            foreach (decimal item in pricePurchase)
            {
                total += item;
            }
            actualTotal = total;
            tbTotal.Text = actualTotal.ToString();
        }

        private int AmountOfFoodAvailable(string foodName)
        {
            int amountFood = 0;
            string sqlAmountOfProduct = $"SELECT Amount FROM products WHERE ProductName = '{foodName}';";
            MySqlCommand amountOfProductCommand = new MySqlCommand(sqlAmountOfProduct, connection);
            try
            {
                connection.Open();
                MySqlDataReader amountOfProductReader = amountOfProductCommand.ExecuteReader();

                while (amountOfProductReader.Read())
                {
                    amountFood = Convert.ToInt32(amountOfProductReader["Amount"]);
                }
                return amountFood;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return amountFood;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
                return amountFood;
            }
            finally
            {
                connection.Close();
            }
        }

        private decimal GetClientBalance()
        {
            decimal clientBalance = 0;
            string sqlGetVisitorsID = $"SELECT Balance FROM visitor WHERE rfidID = '{userRFID}';";
            MySqlCommand visitorBalanceCommand = new MySqlCommand(sqlGetVisitorsID, connection);
            try
            {
                connection.Open();
                MySqlDataReader visitorBalanceReader = visitorBalanceCommand.ExecuteReader();

                while (visitorBalanceReader.Read())
                {
                    clientBalance = Convert.ToDecimal(visitorBalanceReader["Balance"]);
                }
                return clientBalance;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return clientBalance;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
                return clientBalance;
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateClientsBalance()
        {
            decimal clientBalance = GetClientBalance();
            decimal newBalance = clientBalance - actualTotal;
            string sqlUpdateBalance = $"UPDATE visitor SET Balance = '{newBalance}' WHERE rfidID = '{userRFID}';";
            MySqlCommand updateBalanceCommand = new MySqlCommand(sqlUpdateBalance, connection);
            try
            {
                connection.Open();
                updateBalanceCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private bool CheckIfIDExist()
        {
            List<string> listRFID = new List<string>();
            string clientCheckID = "";
            string sqlList_rfidID = $"SELECT rfidID FROM rfid";
            MySqlCommand list_rfidIDCommand = new MySqlCommand(sqlList_rfidID, connection);
            try
            {
                connection.Open();
                MySqlDataReader list_rfidIDReader = list_rfidIDCommand.ExecuteReader();

                while (list_rfidIDReader.Read())
                {
                    listRFID.Add(list_rfidIDReader["rfidID"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
            }
            finally
            {
                connection.Close();
            }
            foreach (string item in listRFID)
            {
                if (item == userRFID)
                {
                    string sqlVisitorRFID = $"SELECT rfidID FROM visitor WHERE rfidID = '{userRFID}';";
                    MySqlCommand checkRFIDlinkClientCommand = new MySqlCommand(sqlVisitorRFID, connection);
                    try
                    {
                        connection.Open();
                        MySqlDataReader checkRFIDlinkClientReader = checkRFIDlinkClientCommand.ExecuteReader();
                        while (checkRFIDlinkClientReader.Read())
                        {
                            clientCheckID = checkRFIDlinkClientReader["rfidID"].ToString();
                        }
                        if (item == clientCheckID)
                        {
                            connection.Close();
                            return true;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                connection.Close();
            }
            return false;
        }

        private void RemoveAmountFromProduct()
        {
            int hamburger = 0; int hotdog = 0; int frikandel = 0; int croquettes = 0;
            foreach (string item in namePurchase)
            {
                if (item == "HAMBURGER")
                {
                    hamburger = AmountOfFoodAvailable(item) - 1;
                    string sqlHamburgers = $"UPDATE products SET Amount = {hamburger} WHERE ProductName = '{item}';";
                    MySqlCommand updateBalanceCommand = new MySqlCommand(sqlHamburgers, connection);
                    try
                    {
                        connection.Open();
                        updateBalanceCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (item == "HOTDOG")
                {
                    hotdog = AmountOfFoodAvailable(item) - 1;
                    string sqlHotdog = $"UPDATE products SET Amount = {hotdog} WHERE ProductName = '{item}';";                    
                    MySqlCommand updateHotdogCommand = new MySqlCommand(sqlHotdog, connection);
                    try
                    {
                        connection.Open();
                        updateHotdogCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (item == "FRIKANDEL")
                {
                    frikandel = AmountOfFoodAvailable(item) - 1;
                    string sqlFrikandel = $"UPDATE products SET Amount = {frikandel} WHERE ProductName = '{item}';";
                    MySqlCommand updateFrikandelCommand = new MySqlCommand(sqlFrikandel, connection);
                    try
                    {
                        connection.Open();
                        updateFrikandelCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (item == "CROQUETTES")
                {
                    croquettes = AmountOfFoodAvailable(item) - 1;
                    string sqlCroquettes = $"UPDATE products SET Amount = {croquettes} WHERE ProductName = '{item}';";
                    MySqlCommand updateCroquettesCommand = new MySqlCommand(sqlCroquettes, connection);
                    try
                    {
                        connection.Open();
                        updateCroquettesCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private int GetUserID()
        {

            string sqlGetUserID = $"SELECT UserID FROM visitor WHERE rfidID = '{userRFID}';";
            MySqlCommand getUserIDcommand = new MySqlCommand(sqlGetUserID, connection);
            try
            {
                connection.Open();
                MySqlDataReader getUserIDreader = getUserIDcommand.ExecuteReader();
                while (getUserIDreader.Read())
                {
                    userID = Convert.ToInt32(getUserIDreader["UserID"]);
                }
                getUserIDreader.Close();
                return userID;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return userID;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
                return userID;
            }
            finally
            {
                connection.Close();
            }
        }

        private void HandelTransactionForDB()
        {
            int userID = GetUserID();
           
            int hamburgers = 0;
            int hotdogs = 0;
            int frikandel = 0;
            int croquette = 0;

            List<int> productAmount = new List<int>();
            List<string> productName = new List<string>();
            List<int> productID = new List<int>();

            if (userID != -1)
            {
                foreach (string item in namePurchase)
                {
                    if (item == "HAMBURGER")
                    {
                        if (!productName.Contains("HAMBURGER"))
                        {
                            productName.Add("HAMBURGER");
                            hamburgers++;

                            string sqlGetProductID = $"SELECT ProductID FROM products WHERE ProductName = '{item}';";
                            MySqlCommand getProductIDcommand = new MySqlCommand(sqlGetProductID, connection);
                            try
                            {
                                connection.Open();
                                MySqlDataReader getProductIDreader = getProductIDcommand.ExecuteReader();
                                while (getProductIDreader.Read())
                                {
                                    productID.Add(Convert.ToInt32(getProductIDreader["ProductID"]));
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            catch (Exception exs)
                            {
                                MessageBox.Show(exs.ToString());
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        else
                        {
                            hamburgers++;
                        }
                    }
                    else if (item == "HOTDOG")
                    {
                        if (!productName.Contains("HOTDOG"))
                        {
                            productName.Add("HOTDOG");
                            hotdogs++;

                            string sqlGetProductID = $"SELECT ProductID FROM products WHERE ProductName = '{item}';";
                            MySqlCommand getProductIDcommand = new MySqlCommand(sqlGetProductID, connection);
                            try
                            {
                                connection.Open();
                                MySqlDataReader getProductIDreader = getProductIDcommand.ExecuteReader();
                                while (getProductIDreader.Read())
                                {
                                    productID.Add(Convert.ToInt32(getProductIDreader["ProductID"]));
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            catch (Exception exs)
                            {
                                MessageBox.Show(exs.ToString());
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        else
                        { hotdogs++; }
                    }
                    else if (item == "FRIKANDEL")
                    {
                        if (!productName.Contains("FRIKANDEL"))
                        {
                            productName.Add("FRIKANDEL");
                            frikandel++;

                            string sqlGetProductID = $"SELECT ProductID FROM products WHERE ProductName = '{item}';";
                            MySqlCommand getProductIDcommand = new MySqlCommand(sqlGetProductID, connection);
                            try
                            {
                                connection.Open();
                                MySqlDataReader getProductIDreader = getProductIDcommand.ExecuteReader();
                                while (getProductIDreader.Read())
                                {
                                    productID.Add(Convert.ToInt32(getProductIDreader["ProductID"]));
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            catch (Exception exs)
                            {
                                MessageBox.Show(exs.ToString());
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        else
                        { frikandel++; }
                    }
                    else if (item == "CROQUETTES")
                    {
                        if (!productName.Contains("CROQUETTES"))
                        {
                            productName.Add("CROQUETTES");
                            croquette++;

                            string sqlGetProductID = $"SELECT ProductID FROM products WHERE ProductName = '{item}';";
                            MySqlCommand getProductIDcommand = new MySqlCommand(sqlGetProductID, connection);
                            try
                            {
                                connection.Open();
                                MySqlDataReader getProductIDreader = getProductIDcommand.ExecuteReader();
                                while (getProductIDreader.Read())
                                {
                                    productID.Add(Convert.ToInt32(getProductIDreader["ProductID"]));
                                }
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            catch (Exception exs)
                            {
                                MessageBox.Show(exs.ToString());
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        else
                        { croquette++; }
                    }
                }

                foreach (string item in productName)
                {
                    if (item == "HAMBURGER")
                    {
                        productAmount.Add(hamburgers);
                    }
                    else if (item == "HOTDOG")
                    {
                        productAmount.Add(hotdogs);
                    }
                    else if (item == "FRIKANDEL")
                    {
                        productAmount.Add(frikandel);
                    }
                    else if (item == "CROQUETTES")
                    {
                        productAmount.Add(croquette);
                    }
                }

                for (int i = 0; i < productID.Count; i++)
                {
                    string sqlInsertTransaction = $"INSERT INTO buyproduct (ProductID, Amount, UserID) VALUES ({productID[i]}, {productAmount[i]}, {userID});";
                    MySqlCommand insertTransactionCommand = new MySqlCommand(sqlInsertTransaction, connection);
                    try
                    {
                        connection.Open();
                        insertTransactionCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception exs)
                    {
                        MessageBox.Show(exs.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        #endregion 
    }
}
