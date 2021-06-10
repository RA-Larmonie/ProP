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

namespace Food_shop_souvenirs
{
    public partial class Form1 : Form
    {
        #region FIELDS
        private RFID myRFIDReader;
        private MySqlConnection connection;

        List<string> purchase = new List<string>();
        List<decimal> pricePurchase = new List<decimal>();
        List<string> namePurchase = new List<string>();

        decimal actualTotal = 0;
        private int userID = 0;
        private string userRFID = "";
        #endregion

        #region CONSTRUCTOR 
        public Form1()
        {
            InitializeComponent();
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
        #endregion

        #region BUTTON FOR SOUVENIRS
        private void btKeychain_Click(object sender, EventArgs e)
        {
            ProductToBuy("KEYCHAIN");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btBandanna_Click(object sender, EventArgs e)
        {
            ProductToBuy("BANDANNA");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btMug_Click(object sender, EventArgs e)
        {
            ProductToBuy("MUG");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btShirt_Click(object sender, EventArgs e)
        {
            ProductToBuy("T-SHIRT");
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
                int keychain = 0; int keychainAmount = AmountOfSouvenirAvailable("KEYCHAIN"); bool _keychain;
                int shirt = 0; int shirtAmount = AmountOfSouvenirAvailable("T-SHIRT"); bool _shirt;
                int mug = 0; int mugAmount = AmountOfSouvenirAvailable("MUG"); bool _mug;
                int bandanna = 0; int bandannaAmount = AmountOfSouvenirAvailable("BANDANNA"); bool _bandanna;

                foreach (string item in namePurchase)
                {
                    if (item == "KEYCHAIN")
                    { keychain++; }
                    else if (item == "T-SHIRT")
                    { shirt++; }
                    else if (item == "MUG")
                    { mug++; }
                    else if (item == "BANDANNA")
                    { bandanna++; }
                }

                if (keychain >= 0 && keychain < keychainAmount)
                { _keychain = true; }
                else
                {
                    _keychain = false;
                    MessageBox.Show($"There is {keychainAmount} keychain available and you asked for {keychain}");
                }
                if (shirt >= 0 && shirt < shirtAmount)
                { _shirt = true; }
                else
                {
                    _shirt = false;
                    MessageBox.Show($"There is {shirtAmount} T-shirt available and you asked for {shirt}");
                }
                if (mug >= 0 && mug < mugAmount)
                { _mug = true; }
                else
                {
                    _mug = false;
                    MessageBox.Show($"There is {mugAmount} mugs available and you asked for {mug}");
                }
                if (bandanna >= 0 && bandanna < bandannaAmount)
                { _bandanna = true; }
                else
                {
                    _bandanna = false;
                    MessageBox.Show($"There is {bandannaAmount} bandanna available and you asked for {bandanna}");
                }

                //check if the register person has enough
                if (_keychain && _shirt && _mug && _bandanna)
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
                        MessageBox.Show("The client has insufficient balance");
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

        #region BUTTON TO CANCEL PURCHASE
        private void btCancel_Click(object sender, EventArgs e)
        {
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
        #endregion

        #region BUTTON TO REMOVE ITEM FROM PURCHASE LIST
        private void btRemove_Click(object sender, EventArgs e)
        {
            RemoveFromPurchasing();
            UpdateListbox();
            UpdatePurchaseList();
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
                //connection.Close();
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
                    product = productNameReader[0].ToString();
                    if (product != "MUG")
                    {
                        product = productNameReader[0].ToString() + " \t";
                        namePurchase.Add(productNameReader["ProductName"].ToString());
                    }
                    else
                    {
                        product = productNameReader[0].ToString() + " \t" + "\t";
                        namePurchase.Add(productNameReader["ProductName"].ToString());
                    }
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

            try
            {
                connection.Open();
                MySqlCommand productPriceCommand = new MySqlCommand(sqlProductPrice, connection);
                MySqlDataReader productPriceReader = productPriceCommand.ExecuteReader();

                while (productPriceReader.Read())
                {
                    product += Convert.ToDecimal(productPriceReader["Price"]);
                    pricePurchase.Add(Convert.ToDecimal(productPriceReader["Price"]));
                }
                purchase.Add(product);
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

        private int AmountOfSouvenirAvailable(string souvenirName)
        {
            int amountSouvenir = 0;
            string sqlAmountOfProduct = $"SELECT Amount FROM products WHERE ProductName = '{souvenirName}';";
            MySqlCommand amountOfProductCommand = new MySqlCommand(sqlAmountOfProduct, connection);
            try
            {
                connection.Open();
                MySqlDataReader amountOfProductReader = amountOfProductCommand.ExecuteReader();

                while (amountOfProductReader.Read())
                {
                    amountSouvenir = Convert.ToInt32(amountOfProductReader["Amount"]);
                }
                return amountSouvenir;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return amountSouvenir;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
                return amountSouvenir;
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

        //come back to this to check if id registred to client
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
                    connection.Open();
                    MySqlCommand checkRFIDlinkClientCommand = new MySqlCommand(sqlVisitorRFID, connection);
                    try
                    {
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
            }
            return false;
        }

        private void RemoveAmountFromProduct()
        {
            int keychain = 0; int shirt = 0; int mug = 0; int bandanna = 0;
            foreach (string item in namePurchase)
            {
                if (item == "KEYCHAIN")
                {
                    keychain = AmountOfSouvenirAvailable(item) - 1;
                    string sqlKeychain = $"UPDATE products SET Amount = {keychain} WHERE ProductName = '{item}';";
                    MySqlCommand keychainCommand = new MySqlCommand(sqlKeychain, connection);
                    try
                    {
                        connection.Open();
                        keychainCommand.ExecuteNonQuery();
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
                else if (item == "T-SHIRT")
                {
                    shirt = AmountOfSouvenirAvailable(item) - 1;
                    string sqlShirt = $"UPDATE products SET Amount = {shirt} WHERE ProductName = '{item}';";
                    MySqlCommand updateShirtCommand = new MySqlCommand(sqlShirt, connection);
                    try
                    {
                        connection.Open();
                        updateShirtCommand.ExecuteNonQuery();
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
                else if (item == "MUG")
                {
                    mug = AmountOfSouvenirAvailable(item) - 1;
                    string sqlMug = $"UPDATE products SET Amount = {mug} WHERE ProductName = '{item}';";
                    MySqlCommand updateMugCommand = new MySqlCommand(sqlMug, connection);
                    try
                    {
                        connection.Open();
                        updateMugCommand.ExecuteNonQuery();
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
                else if (item == "BANDANNA")
                {
                    bandanna = AmountOfSouvenirAvailable(item) - 1;
                    string sqlBandanna = $"UPDATE products SET Amount = {bandanna} WHERE ProductName = '{item}';";
                    MySqlCommand updateBandannaCommand = new MySqlCommand(sqlBandanna, connection);
                    try
                    {
                        connection.Open();
                        updateBandannaCommand.ExecuteNonQuery();
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

        private void HandelTransactionForDB()
        {                                   
            int keychain = 0;
            int shirt = 0;
            int mug = 0;
            int bandanna = 0;

            List<int> productAmount = new List<int>();
            List<string> productName = new List<string>();
            List<int> productID = new List<int>();

            if (userID != 0)
            {
                foreach (string item in namePurchase)
                {
                    if (item == "KEYCHAIN")
                    {
                        if (!productName.Contains("KEYCHAIN"))
                        {
                            productName.Add("KEYCHAIN");
                            keychain++;

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
                            keychain++;
                        }
                    }
                    else if (item == "T-SHIRT")
                    {
                        if (!productName.Contains("T-SHIRT"))
                        {
                            productName.Add("T-SHIRT");
                            shirt++;

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
                        { shirt++; }
                    }
                    else if (item == "MUG")
                    {
                        if (!productName.Contains("MUG"))
                        {
                            productName.Add("MUG");
                            mug++;

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
                        { mug++; }
                    }
                    else if (item == "BANDANNA")
                    {
                        if (!productName.Contains("BANDANNA"))
                        {
                            productName.Add("BANDANNA");
                            bandanna++;
                           
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
                            bandanna++;
                         }
                    }
                }

                foreach (string item in productName)
                {
                    if (item == "KEYCHAIN")
                    {
                        productAmount.Add(keychain);
                    }
                    else if (item == "T-SHIRT")
                    {
                        productAmount.Add(shirt);
                    }
                    else if (item == "MUG")
                    {
                        productAmount.Add(mug);
                    }
                    else if (item == "BANDANNA")
                    {
                        productAmount.Add(bandanna);
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
