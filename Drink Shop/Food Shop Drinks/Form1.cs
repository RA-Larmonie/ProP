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

namespace Food_Shop_Drinks
{
    public partial class Form1 : Form
    {
        #region FIELDS
        private MySqlConnection connection;
        private RFID myRFIDReader;

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

        #region BUTTON FOR DRINKS
        private void btBavaria_Click(object sender, EventArgs e)
        {
            ProductToBuy("BAVARIA");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btFuzeTea_Click(object sender, EventArgs e)
        {
            ProductToBuy("FUZE TEA");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btCocaCola_Click(object sender, EventArgs e)
        {
            ProductToBuy("COCA COLA");
            UpdateListbox();
            UpdatePurchaseList();
        }

        private void btHeiniken_Click(object sender, EventArgs e)
        {
            ProductToBuy("HEINIKEN");
            UpdateListbox();
            UpdatePurchaseList();
        }
        #endregion

        #region BUTTON PURCHASE DRINKS
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
            else if (PurchasingAlcohol() && !CheckAge())
            {
                MessageBox.Show("This person is a minor." +
                    "\n He/She is not permitted to purchase alcohol");
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
            else
            {
                int heiniken = 0; int heinikenAmount = AmountOfDrinkAvailable("HEINIKEN"); bool _heiniken;
                int bavaria = 0; int bavariaAmount = AmountOfDrinkAvailable("BAVARIA"); bool _bavaria;
                int fuseTea = 0; int fuseTeaAmount = AmountOfDrinkAvailable("FUZE TEA"); bool _fuseTea;
                int cocaCola = 0; int cocaColaAmount = AmountOfDrinkAvailable("COCA COLA"); bool _cocaCola;

                foreach (string item in namePurchase)
                {
                    if (item == "HEINIKEN")
                    { heiniken++; }
                    else if (item == "FUZE TEA")
                    { fuseTea++; }
                    else if (item == "BAVARIA")
                    { bavaria++; }
                    else if (item == "COCA COLA")
                    { cocaCola++; }
                }


                if (heiniken >= 0 && heiniken < heinikenAmount)
                { _heiniken = true; }
                else
                {
                    _heiniken = false;
                    MessageBox.Show($"There is {heinikenAmount} heiniken available and you asked for {heiniken}");
                }
                if (bavaria >= 0 && bavaria < bavariaAmount)
                { _bavaria = true; }
                else
                {
                    _bavaria = false;
                    MessageBox.Show($"There is {bavariaAmount} bavaria available and you asked for {bavaria}");
                }
                if (fuseTea >= 0 && fuseTea < fuseTeaAmount)
                { _fuseTea = true; }
                else
                {
                    _fuseTea = false;
                    MessageBox.Show($"There is {fuseTeaAmount} fuze tea available and you asked for {fuseTea}");
                }
                if (cocaCola >= 0 && cocaCola < cocaColaAmount)
                { _cocaCola = true; }
                else
                {
                    _cocaCola = false;
                    MessageBox.Show($"There is {cocaColaAmount} coca cola available and you asked for {cocaCola}");
                }

                //check if the register person has enough
                if (_heiniken && _bavaria && _fuseTea && _cocaCola)
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

        #region BUTTON TO REMOVE ITEM
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
            listBox1.Items.Clear();
            userID = 0;
            userRFID = "";
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

        private bool CheckAge()
        {
            int age = 0;
            string sql = $"SELECT DATEDIFF(DATE_FORMAT(CURRENT_DATE,'%Y-%m-%d'), DateOfBirth) FROM visitor WHERE UserID = {userID};";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    age = (Convert.ToInt32(reader[0]) / 365);
                }

                if (age >= 18)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.ToString());
                return false;
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
            {   //if the scanned rfid is in the list of rfid
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
                        // if the rfid belogns to a visitor
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

        private int AmountOfDrinkAvailable(string drinkName)
        {
            int amountDrink = 0;
            string sqlAmountOfProduct = $"SELECT Amount FROM products WHERE ProductName = '{drinkName}';";
            MySqlCommand amountOfProductCommand = new MySqlCommand(sqlAmountOfProduct, connection);
            try
            {
                connection.Open();
                MySqlDataReader amountOfProductReader = amountOfProductCommand.ExecuteReader();

                while (amountOfProductReader.Read())
                {
                    amountDrink = Convert.ToInt32(amountOfProductReader["Amount"]);
                }
                return amountDrink;
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
            return amountDrink;
        }

        private bool PurchasingAlcohol()
        {
            foreach (string item in namePurchase)
            {
                string sql = $"SELECT IsAlcohol FROM products WHERE ProductName = '{item}';";
                MySqlCommand command = new MySqlCommand(sql, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader["IsAlcohol"]) == 1)
                        {
                            connection.Close(); return true;
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
            }
            return false;
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

        private decimal GetClientBalance()
        {
            decimal clientBalance = 0;
            string sqlGetVisitorsID = $"SELECT Balance FROM visitor WHERE rfidID = '{userRFID}'";
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

        private void RemoveAmountFromProduct()
        {
            int heiniken = 0; int bavaria = 0; int fuzeTea = 0; int cocaCola = 0;
            foreach (string item in namePurchase)
            {
                if (item == "HEINIKEN")
                {
                    heiniken = AmountOfDrinkAvailable(item) - 1;
                    string sqlHeiniken = $"UPDATE products SET Amount = {heiniken} WHERE ProductName = '{item}';";                    
                    MySqlCommand updateHeinikenCommand = new MySqlCommand(sqlHeiniken, connection);
                    try
                    {
                        connection.Open();
                        updateHeinikenCommand.ExecuteNonQuery();
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
                else if (item == "BAVARIA")
                {
                    bavaria = AmountOfDrinkAvailable(item) - 1;
                    string sqlBavaria = $"UPDATE products SET Amount = {bavaria} WHERE ProductName = '{item}';";
                    MySqlCommand updateBavariaCommand = new MySqlCommand(sqlBavaria, connection);
                    try
                    {
                        connection.Open();
                        updateBavariaCommand.ExecuteNonQuery();
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
                else if (item == "FUZE TEA")
                {
                    fuzeTea = AmountOfDrinkAvailable(item) - 1;
                    string sqlFuzeTea = $"UPDATE products SET Amount = {fuzeTea} WHERE ProductName = '{item}';";
                    MySqlCommand updateFuzeTeaCommand = new MySqlCommand(sqlFuzeTea, connection);
                    try
                    {
                        connection.Open();
                        updateFuzeTeaCommand.ExecuteNonQuery();
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
                else if (item == "COCA COLA")
                {
                    cocaCola = AmountOfDrinkAvailable(item) - 1;
                    string sqlCocaCola = $"UPDATE products SET Amount = {cocaCola} WHERE ProductName = '{item}';";
                    MySqlCommand updateCocaColaCommand = new MySqlCommand(sqlCocaCola, connection);
                    try
                    {
                        connection.Open();
                        updateCocaColaCommand.ExecuteNonQuery();
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
            int heiniken = 0;
            int bavaria = 0;
            int fuzeTea = 0;
            int cocaCola = 0;

            List<int> productAmount = new List<int>();
            List<string> productName = new List<string>();
            List<int> productID = new List<int>();

            if (userID != 0)
            {
                foreach (string item in namePurchase)
                {
                    if (item == "HEINIKEN")
                    {
                        if (!productName.Contains("HEINIKEN"))
                        {
                            productName.Add("HEINIKEN");
                            heiniken++;

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
                            heiniken++;
                        }
                    }
                    else if (item == "BAVARIA")
                    {
                        if (!productName.Contains("BAVARIA"))
                        {
                            productName.Add("BAVARIA");
                            bavaria++;

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
                        { bavaria++; }
                    }
                    else if (item == "FUZE TEA")
                    {
                        if (!productName.Contains("FUZE TEA"))
                        {
                            productName.Add("FUZE TEA");
                            fuzeTea++;

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
                        { fuzeTea++; }
                    }
                    else if (item == "COCA COLA")
                    {
                        if (!productName.Contains("COCA COLA"))
                        {
                            productName.Add("COCA COLA");
                            cocaCola++;

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
                        { cocaCola++; }
                    }
                }

                foreach (string item in productName)
                {
                    if (item == "HEINIKEN")
                    {
                        productAmount.Add(heiniken);
                    }
                    else if (item == "BAVARIA")
                    {
                        productAmount.Add(bavaria);
                    }
                    else if (item == "FUZE TEA")
                    {
                        productAmount.Add(fuzeTea);
                    }
                    else if (item == "COCA COLA")
                    {
                        productAmount.Add(cocaCola);
                    }
                }

                for (int i = 0; i < productID.Count(); i++)
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
