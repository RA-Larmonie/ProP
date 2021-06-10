using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Check_In_and_check_out_GUI
{

    class SQLDataControl
    {
        //General connection -Form1,ItemForm and addProductFrom 
        MySqlConnection sqlConnection;
        //Camping connection -Camping Form
        MySqlConnection campingConnection;
        //Visitor connection -VisitorForm
        MySqlConnection visitorConnection;

        //Database connection
        public SQLDataControl()
        {
            string dbConnectionInfo
             = "server=studmysql01.fhict.local;Uid=dbi393800;database=dbi393800;password=ralia12345;";

            sqlConnection = new MySqlConnection(dbConnectionInfo);
            campingConnection = new MySqlConnection(dbConnectionInfo);
            visitorConnection = new MySqlConnection(dbConnectionInfo);
           
        }

        public void Connect()
        {
            sqlConnection.Open();
        }
        public void Disconnect()
        {
            visitorConnection.Close();
        }
        // Retrieving data from database
        //SQL Statements


        #region Checked-IN CHECKED-OUT
        //-------------------------------CHECKED-IN CHECKED-OUT--------------------------------




        //Not Implemented
        //Get number of visitors who checked in from camping
        public double GetNumberOfVisitorCheckedInCamping()
        {
            try
            {
                string SqlGetVisitorCampCheckedIn = "SELECT Count(UserID) From camping;";
                MySqlCommand GetCampCheckedInVisitors = new MySqlCommand(SqlGetVisitorCampCheckedIn, sqlConnection);
                sqlConnection.Open();
                double NumberOfCampCheckedInVisitors = Convert.ToDouble(GetCampCheckedInVisitors.ExecuteScalar());

                return NumberOfCampCheckedInVisitors;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }


        }
        
        //// Get number of visitors who checked out from camping
        //public double GetVisitorCheckedOutCamping()
        //{
        //    string SqlGetVisitorCampCheckedOut = "SELECT Count(UserID) From Visitor Where C";
        //    MySqlCommand GetCampCheckedOutVisitors = new MySqlCommand(SqlGetVisitorCampCheckedOut, sqlConnection);
        //    double NumberOfCampCheckedOutVisitors = Convert.ToDouble(GetCampCheckedOutVisitors.ExecuteScalar());

        //    return NumberOfCampCheckedOutVisitors;
        //}

        //Not implemented
        //Get Specific visitor who checked-in/out event
        //public List<bool> GetParticularVisitorCheckecdInEvent(int userID)
        //{
        //    List<bool> ListVisitorCheckedIn = new List<bool>();

        //    string SqlStatementVisitor = "SELECT CheckedInEvent " +
        //        "FROM visitor" +
        //        "WHERE UserID=@GivenUserID";
        //    MySqlCommand SqlCommand = new MySqlCommand(SqlStatementVisitor, sqlConnection);
        //    SqlCommand.Parameters.AddWithValue("@GivenUserID", userID);

        //    MySqlDataReader reader = SqlCommand.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        ListVisitorCheckedIn.Add(Convert.ToBoolean(reader[0]));
        //    }

        //    bool ParticularVisitor = Convert.ToBoolean(SqlCommand.ExecuteScalar());
        //    return ListVisitorCheckedIn;
        //}

        ////Not implemented
        ////Get Specific visitor who checked-in/out camping
        //public List<bool> GetParticularVisitorCheckedInCamping(int userID)
        //{
        //    List<bool> ListVisitorCheckedIn = new List<bool>();

        //    string SQLStatementCamping = "SELECT UserID " +
        //        "FROM camping " +
        //        "WHERE UserID=@GivenUserID";

        //    MySqlCommand sqlCommand = new MySqlCommand(SQLStatementCamping, sqlConnection);
        //    sqlCommand.Parameters.AddWithValue("@GivenUserID", userID);

        //    MySqlDataReader reader = sqlCommand.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        ListVisitorCheckedIn.Add(Convert.ToBoolean(reader[0]));
        //    }

           

        //    return ListVisitorCheckedIn;
        //}
        #endregion

        #region Profits 
        //---------------------------------------PROFITS---------------------------------------



        //Not implemented
        // Get Amount of Specific Sold Product
        public double GetSpecificProductAmountSold(int ProductID)
        {
            try
            {
                string SqlGetSpecificProductAmountSold = "SELECT COUNT(ProductID) FROM buyproduct" +
                "WHERE ProductID=@GivenProductID";
                MySqlCommand SpecificAmountProductsSold = new MySqlCommand(SqlGetSpecificProductAmountSold, sqlConnection);
                sqlConnection.Open();
                SpecificAmountProductsSold.Parameters.AddWithValue("@GivenProductID", ProductID);

                double SpecificProductSold = Convert.ToDouble(SpecificAmountProductsSold.ExecuteScalar());

                return SpecificProductSold;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }


        }


        //Not Implemented
        // Get Amount of Specific Loaned Product by PRODUCT ID
        public double GetSpecificProductAmountLoaned(int ProductID)
        {
            try
            {
                string SqlGetSpecificProductAmountLoaned = "SELECT COUNT(ProductID) FROM loanproduct" +
                "WHERE ProductID=@GivenProductID";
                MySqlCommand SpecificAmountProductLoaned = new MySqlCommand(SqlGetSpecificProductAmountLoaned, sqlConnection);
                sqlConnection.Open();
                SpecificAmountProductLoaned.Parameters.AddWithValue("@GivenProductID", ProductID);

                double SpecificProductLoaned = Convert.ToDouble(SpecificAmountProductLoaned.ExecuteScalar());

                return SpecificProductLoaned;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }



        }
        #endregion

        #region Camping Infomation & Camping Form
        //-----------------------------------------CAMPING-------------------------------------------

        //Not Implemented
        //Get All camping spots       
        public int GetAllCampingSpots()
        {
            try
            {
                string SqlGetAllCampingSpots = "SELECT Count(CampSpots) FROM camping;";

                MySqlCommand AllCampingSpots = new MySqlCommand(SqlGetAllCampingSpots, sqlConnection);
                sqlConnection.Open();
                int NumberOfAllSpots = Convert.ToInt32(AllCampingSpots.ExecuteScalar());

                return NumberOfAllSpots;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Implemented
        //Number of taken camping spots
        public int NumberOfTakenCampingSpots()
        {
            try
            {
                string SqlGetTakenCampingSpots = "SELECT COUNT(*) " +
                    "FROM camping " +
                    "WHERE status='1';";
                    

                MySqlCommand NumberOfTakenSpots = new MySqlCommand(SqlGetTakenCampingSpots, sqlConnection);
                sqlConnection.Open();
                int TakenCampingSpots = Convert.ToInt32(NumberOfTakenSpots.ExecuteScalar());

                return TakenCampingSpots;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Implemented
        //Get stard date of camping
        public string GetStardDateOfCamping(int CampID)
        {
            string StartDate = "";

            try
            {
                string sqlStatement = $"SELECT StartDate FROM assigncamping WHERE CampID= {CampID};";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, campingConnection);

                campingConnection.Open();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                reader.Read();

                StartDate = reader[0].ToString();


                reader.Close();
                return StartDate;
            }
            catch
            {
                return StartDate;
            }
            finally
            {
                campingConnection.Close();
            }
            

            
        }
        //Implemented
        //Get End date of camping
        public string GetEndDateOfCamping(int CampID)
        {
            string EndDate = "";
            try
            {
                string sqlStatement = $"SELECT EndDate FROM assigncamping WHERE CampID= {CampID};";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, campingConnection);

                campingConnection.Open();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                reader.Read();

                EndDate = reader[0].ToString();

                reader.Close();
                return EndDate;
            }
            catch
            {
                return EndDate;
            }
            finally
            {
                campingConnection.Close();
            }

        }
        
        //Implemented
        //Get user first name,last name and user IDfor camping
        public List<string> GetUserFirstNameCamping(int CampID)
        {
            List<string> UserID = new List<string>();
            string sqlStatement = $"SELECT visitor.UserFirstName,visitor.UserLastName,assigncamping.UserID" +
                $" FROM assigncamping RIGHT JOIN visitor on (visitor.UserID=assigncamping.UserID)" +
                $"WHERE CampID= {CampID};";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, campingConnection);

            campingConnection.Open();


            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                UserID.Add(Convert.ToString(" First name: " + reader[0]+"||") +
                          (Convert.ToString(" Last name: " + reader[1]+"||") +
                          (Convert.ToString(" User id: " + reader[2]))));
            }

            reader.Close();

            campingConnection.Close();

            return UserID;
        }
        public int NumberOfBookedSpots(int CampID)
        {
            int BookedSpots = 0;
            try
            {
                string sqlStatement = $"SELECT BookedSpots FROM camping WHERE CampID ={CampID};";

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, campingConnection);

                campingConnection.Open();
                BookedSpots = Convert.ToInt32(sqlCommand.ExecuteScalar());

                if (BookedSpots == 0)
                {
                    MessageBox.Show(CampID + " has no bookings ");
                }
                else
                {
                    return BookedSpots;
                }
                return BookedSpots;

            }
            catch
            {
                return BookedSpots;
            }
            finally
            {
                campingConnection.Close();
            }
           
         


        }
        //Implemented
        //List of available camping spots
        public List<string> GetListOfAvailableCampingSpots()
        {
            List<string> AvailableCampingSpots = new List<string>();

            string SqlStatement = "SELECT distinct(camping.CampID),camping.BookedSpots " +
            "FROM camping "+
            "WHERE Status='0';";
            MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, campingConnection);
                campingConnection.Open();
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    AvailableCampingSpots.Add(Convert.ToString("CampId: "+reader[0])+
                                             (Convert.ToString(" Booked spots: "+reader[1])));
                }
                reader.Close();
                campingConnection.Close();
                return AvailableCampingSpots;
  
        }
        
        //Implemented
        //List of taken camping spots
        public List<string> GetListOfTakenCampingSpots()
        {
            List<string> TakenCampingSpots = new List<string>();

            string SqlStatement = "Select CampID from camping where Status='1'";

            MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, campingConnection);

            campingConnection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                TakenCampingSpots.Add(Convert.ToString("CampId: " + reader[0])); 
                                    
            }
            reader.Close();
            campingConnection.Close();
            return TakenCampingSpots;
        }
        #endregion

        #region Visitor information & Visitor Form
        //----------------------------------VISITORS-------------------------------------------

        //Not Implemented
        //Get number of visitors who got account 
        public double GetVisitors()
        {
            try
            {
                string SqlGetVisitors = "SELECT COUNT(UserID) " +
                    "FROM visitor;";

                MySqlCommand GetPossibleVisitors = new MySqlCommand(SqlGetVisitors, sqlConnection);
                sqlConnection.Open();
                double NumberOfVisitors = Convert.ToDouble(GetPossibleVisitors.ExecuteScalar());

                return NumberOfVisitors;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }



        
        //Implemented
        //Get all visitor who bought product
        public List<string> GetAllProductBuyers()
        {
            List<string> AllProductBuyersInfo = new List<string>();

            string SqlGetAllProductBuyers = "SELECT distinct(buyproduct.UserID) FROM buyproduct ;";
            

            MySqlCommand AllBuyersInfo = new MySqlCommand(SqlGetAllProductBuyers, visitorConnection);
            visitorConnection.Open();
            MySqlDataReader ReaderProductBuyers = AllBuyersInfo.ExecuteReader();

            while (ReaderProductBuyers.Read())
            {
                AllProductBuyersInfo.Add("User id: " + Convert.ToString(ReaderProductBuyers[0])); 
            }
            ReaderProductBuyers.Close();

            visitorConnection.Close();
            return AllProductBuyersInfo;
        }
        //Implemented
        //Get all visitor who loaned product
        public List<string> GetAllUserLoaned()
        {

            List<string> AllLoanBuyersInfo = new List<string>();


            string SqlGetAllLoanBuyers = "SELECT UserID FROM loanproduct;";


                MySqlCommand AllLoanersInfo = new MySqlCommand(SqlGetAllLoanBuyers, visitorConnection);
                visitorConnection.Open();
                MySqlDataReader ReaderProductBuyers = AllLoanersInfo.ExecuteReader();

                while (ReaderProductBuyers.Read())
                {
                    AllLoanBuyersInfo.Add("User id: " + Convert.ToString(ReaderProductBuyers[0]));
                                         
                }
                ReaderProductBuyers.Close();

                visitorConnection.Close();
                return AllLoanBuyersInfo;
        }
        //Implemented
        //Get visitor FirstName
        public string GetVisitorFirstName(int UserID)
        {
            string sqlVisitorFirstName = $"SELECT UserFirstName FROM visitor WHERE UserID= {UserID};";
            MySqlCommand sqlCommandFirstName = new MySqlCommand(sqlVisitorFirstName, visitorConnection);

            visitorConnection.Open();
            MySqlDataReader readerFirstName = sqlCommandFirstName.ExecuteReader();
            

            readerFirstName.Read();
            string FirstName = readerFirstName[0].ToString();
            readerFirstName.Close();

            visitorConnection.Close();
            return FirstName;
        }
        //Implemented
        //Get visitor Last Name
        public string GetVisitorLastName(int UserID)
        {
            string sqlVisitorLastName = $"SELECT UserLastName FROM visitor WHERE UserID= {UserID};";

            
            MySqlCommand sqlCommandLastName = new MySqlCommand(sqlVisitorLastName, visitorConnection);
            visitorConnection.Open();

            
            MySqlDataReader readerLastName = sqlCommandLastName.ExecuteReader();

            readerLastName.Read();
            string LastName = readerLastName[0].ToString();
            readerLastName.Close();
            visitorConnection.Close();
            return LastName;
        }
        //Implemented
        //Get visitor Balance
        public string GetVisitorBalance(int UserID)
        {
            string sqlVisitorBalance = $"SELECT Balance FROM visitor WHERE UserID={UserID};";

            MySqlCommand sqlCommandBalance = new MySqlCommand(sqlVisitorBalance, visitorConnection);

            visitorConnection.Open();
            MySqlDataReader readerBalance = sqlCommandBalance.ExecuteReader();
            readerBalance.Read();
            string Balance = readerBalance[0].ToString();
            readerBalance.Close();
            visitorConnection.Close();
            return Balance;
        }
        //Implemented
        //Get visitor event status checked-in /out
        public string GetVisitorEventStatus(int UserID)
        {

            int EventStatus = 0;
            string sqlCheckEvent = $"SELECT CheckedInEvent FROM visitor WHERE UserID= {UserID} ";

            MySqlCommand sqlCommandEvent = new MySqlCommand(sqlCheckEvent, visitorConnection);

            visitorConnection.Open();

            MySqlDataReader reader = sqlCommandEvent.ExecuteReader();

            reader.Read();
            EventStatus = Convert.ToInt32(reader[0]);
            reader.Close();
            string Status = ""; 

            if (EventStatus == 1)
            {
                Status = "True";
                visitorConnection.Close();
            }
            else if(EventStatus==0)
            {
                Status = "False";
                visitorConnection.Close();
            }
           
            //visitorConnection.Close();
            return Status;
        }
        //Implemented
        //Get visitor camping status checked-in /out
        public string GetVisitorCampingStatus(int UserID)
        {

            int CampingStatus = 0;
            string sqlCheckEvent = $"SELECT CheckedInCamping FROM visitor WHERE UserID= {UserID} ";

            MySqlCommand sqlCommandEvent = new MySqlCommand(sqlCheckEvent, visitorConnection);

            visitorConnection.Open();

            MySqlDataReader reader = sqlCommandEvent.ExecuteReader();

            reader.Read();
            CampingStatus = Convert.ToInt32(reader[0]);
            reader.Close();
            string Status = "";

            if (CampingStatus == 1)
            {
                Status = "True";
                visitorConnection.Close();
            }
            else if (CampingStatus == 0)
            {
                Status = "False";
                visitorConnection.Close();
            }

            //visitorConnection.Close();
            return Status;
        }
        //Implemented
        //Get number of product that specific user bought
        public int GetSpecificPersonNumberOfProduct(int UserID)
        {
            int NumberOfProduct = 0;

            string sqlVisitorProductBuy = $"SELECT SUM(AMOUNT) FROM buyproduct WHERE UserID={UserID};";

            MySqlCommand sqlCommandProductBuy = new MySqlCommand(sqlVisitorProductBuy, visitorConnection);

            visitorConnection.Open();
            NumberOfProduct = Convert.ToInt32(sqlCommandProductBuy.ExecuteScalar());
            visitorConnection.Close();

            return NumberOfProduct;
        }
        //Implemented
        //Get number of product that specific user loaned
        public int GetSpecificPersonNumberOfLoaned(int UserID)
        {
            int NumberOfLoaned = 0;

            string sqlVisitorLoaned = $"SELECT COUNT(UserID) FROM loanproduct WHERE UserID= {UserID};";

            MySqlCommand sqlCommandLoaned = new MySqlCommand(sqlVisitorLoaned, visitorConnection);

            visitorConnection.Open();

            NumberOfLoaned = Convert.ToInt32(sqlCommandLoaned.ExecuteScalar());
            visitorConnection.Close();

            return NumberOfLoaned;
        }
        public List<string> GetProductSpecificUserBuy(int UserID)
        {
            List<string> Products = new List<string>();

            string sqlstatement = $"SELECT distinct(products.ProductName) " +
                $"FROM products LEFT JOIN buyproduct on (products.productID=buyproduct.ProductID)" +
                $"WHERE buyproduct.UserID ={UserID};";

            MySqlCommand sqlCommand = new MySqlCommand(sqlstatement, visitorConnection);
            visitorConnection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Products.Add(Convert.ToString("Product name: " + reader[0]));
            }
            reader.Close();
            visitorConnection.Close();

            return Products;
        }
        public List<string> GetProductSpecificUserLoaned(int UserID)
        {
            List<string> Products = new List<string>();

            string sqlstatement = $"SELECT distinct(products.ProductName) " +
                $"FROM products LEFT JOIN loanproduct on (products.productID=loanproduct.ProductID)" +
                $"WHERE loanproduct.UserID ={UserID};";

            MySqlCommand sqlCommand = new MySqlCommand(sqlstatement, visitorConnection);
            visitorConnection.Open();
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Products.Add(Convert.ToString("Product name: " + reader[0]));
            }
            reader.Close();
            visitorConnection.Close();

            return Products;
        }

        #endregion

        #region Product&Loaned Item Form
        //----------------------------------Product&Loaned---------------------------------------

        //Implemented
        //Get all the  product names
        public List<string> GetBuyProducts()
        {
            List<string> Products = new List<string>();

            try
            {
                string SqlStatement = $@"SELECT Distinct(ProductName) 
                                       FROM products
                                       WHERE ProductType IN('FOOD','DRINK','SOUVENIR');"; 

                MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, sqlConnection);

                sqlConnection.Open();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Products.Add(reader[0].ToString());
                }
                reader.Close();
                return Products;

            }
            catch
            {
                return Products;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        //Implemented
        //Get all the loan product names
        public List<string> GetLoanProducts()
        {
            List<string> Products = new List<string>();

            try
            {
                string SqlStatement = "SELECT Distinct(ProductName) FROM products " +
                    "WHERE ProductType='LOAN';";

                MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, sqlConnection);

                sqlConnection.Open();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Products.Add(Convert.ToString(reader[0]));
                }
                reader.Close();
                return Products;

            }
            catch
            {
                return Products;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        //Implemented
        //Get Specific  product amount,which is sold
        public int GetSpecificProductAmount(string ProductName)
        {
            int Amount = 0;

            try
            {
                string SqlStatement = "SELECT SUM(buyproduct.Amount) " +
                                       "FROM  buyproduct RIGHT JOIN products on(buyproduct.ProductID = products.ProductID)" +
                                       "WHERE products.ProductName=@GivenProductName ";
                MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@GivenProductName", ProductName);

                Amount = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return Amount;
            }
            catch
            {
                return Amount;
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        //not implemented
        public int GetLoanAmount()
        {
            int Amount = 0;
            string sqlstatement = "SELECT Count(loanproduct.ProductID) " +
                            "FROM loanproduct RIGHT JOIN products on(loanproduct.ProductID = products.ProductID)";

            MySqlCommand sqlCommand = new MySqlCommand(sqlstatement, sqlConnection);
            sqlConnection.Open();

            Amount = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlConnection.Close();
            return Amount;

        }
        public int GetProfitLoan()
        {
            int Profit= 0;
            string sqlstatement = "SELECT SUM(products.Price) " +
                "FROM products " +
                "where ProductID In" +
                "(SELECT ProductID from loanproduct);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlstatement, sqlConnection);
            sqlConnection.Open();

            Profit = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlConnection.Close();

            return Profit;
        }
        //Get Specific Loan product amount,which is loaned 
        //Implemented
        public int GetSpecificLoanAmount(string ProductName)
        {
            int Amount = 0;

            try
            {
                string SqlStatement = "SELECT Count(loanproduct.ProductID) " +
                                       "FROM loanproduct RIGHT JOIN products on(loanproduct.ProductID = products.ProductID)" +
                                       "WHERE products.ProductName=@GivenProductName ";
                MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@GivenProductName", ProductName);

                Amount = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return Amount;
            }
            catch
            {
                return Amount;
            }
            finally
            {
                sqlConnection.Close();
            }



        }
        //Implented
        //Check price of specific product
        public int GetSpecificProductPrice(string ProductName)
        {
            int price = 0;

            try
            {
                string SqlStatement = "SELECT Price " +
               "                 FROM products" +
               "                 WHERE ProductName =@GivenProductName ";

                MySqlCommand sqlCommand = new MySqlCommand(SqlStatement, sqlConnection);

                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@GivenProductName", ProductName);
                price = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return price;
            }
            catch
            {
                return price;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        //Implemented
        //Get visitor who  returned loan item
        public List<string> GetProductLoanersReturned()
        {
            List<string> LoanersWhoReturned = new List<string>();

           
            string SqlGetLoanersReturned = "SELECT visitor.UserID,visitor.UserFirstName,visitor.UserLastName " +
            "FROM visitor LEFT JOIN loanproduct on (visitor.UserID=loanproduct.UserID)" +
            "WHERE loanproduct.ReturnDate IS NOT NULL;";

            MySqlCommand GetLoanersWithReturned = new MySqlCommand(SqlGetLoanersReturned, sqlConnection);
            sqlConnection.Open();
            MySqlDataReader ReaderProductLoanersReturned = GetLoanersWithReturned.ExecuteReader();

            while (ReaderProductLoanersReturned.Read())
            {
                LoanersWhoReturned.Add("User id: " + Convert.ToString(ReaderProductLoanersReturned[0]) + "First Name: \n" +
                                        Convert.ToString(ReaderProductLoanersReturned[1]) + "Last Name: \n " +
                                        Convert.ToString(ReaderProductLoanersReturned[2]));
            }
            ReaderProductLoanersReturned.Close();

            sqlConnection.Close();
            return LoanersWhoReturned;
           

        }

        //Implemented
        //Get visitor who not returned loan item
        public List<string> GetProductLoanersNotReturned()
        {
            List<string> LoanersNotReturned = new List<string>();
 
            string SqlGetLoanersNotReturned = "SELECT visitor.UserID,visitor.UserFirstName,visitor.UserLastName " +
                            "FROM visitor RIGHT JOIN loanproduct on (visitor.UserID=loanproduct.UserID)" +
                            "WHERE loanproduct.ReturnDate IS NULL;";

            MySqlCommand GetLoanersNotReturned = new MySqlCommand(SqlGetLoanersNotReturned, sqlConnection);
            sqlConnection.Open();
            MySqlDataReader ReaderLoanersNotReturned = GetLoanersNotReturned.ExecuteReader();

            while (ReaderLoanersNotReturned.Read())
            {
                LoanersNotReturned.Add("User id: " + Convert.ToString(ReaderLoanersNotReturned[0]) + "First Name: \n" +
                                        Convert.ToString(ReaderLoanersNotReturned[1]) + "Last Name: \n" +
                                        Convert.ToString(ReaderLoanersNotReturned[2]));
            }
            ReaderLoanersNotReturned.Close();

            sqlConnection.Close();
            return LoanersNotReturned;
        }
        //Implemented
        //Check amount of specific product
        public int GetAmountOfSpecificItem(string ProductName)
        {
            int Instock = 0;

            try
            {
                string SqlStament = "SELECT Amount" +
                "                    FROM products" +
                "                    WHERE ProductName=@GivenProductName";

                MySqlCommand sqlCommand = new MySqlCommand(SqlStament, sqlConnection);
                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@GivenProductName", ProductName);

                Instock += Convert.ToInt32(sqlCommand.ExecuteScalar());

                return Instock;
            }
            catch
            {
                return Instock;
            }
            finally
            {
                sqlConnection.Close();
            }


        }
        //Implemented
        //Get amount of specific loan item
        public int GetAmountOfSpecificLoanItem(string ProductName)
        {
            int Instock = 0;

            try
            {
                string SqlStament = "SELECT Count(ProductID)" +
                "                    FROM products" +
                "                    WHERE ProductName=@GivenProductName AND ProductType='LOAN'";

                MySqlCommand sqlCommand = new MySqlCommand(SqlStament, sqlConnection);
                sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("@GivenProductName", ProductName);

                Instock += Convert.ToInt32(sqlCommand.ExecuteScalar());

                return Instock;
            }
            catch
            {
                return Instock;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        
        public List<string> GetProductTypes()
        {
            List<string> ProductTypes = new List<string>();

            try
            {
                string sqlstatement = "SELECT Distinct(ProductType)" +
                               "                 FROM products";

                MySqlCommand sqlCommand = new MySqlCommand(sqlstatement, sqlConnection);

                sqlConnection.Open();

                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ProductTypes.Add(reader[0].ToString());
                }
                reader.Close();

                return ProductTypes;
            }
            catch 
            {
                return ProductTypes;
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
        #endregion

        #region Admin Panel & add product form
        //----------------------------------------ADMIN PANEL----------------------------------------------------

        //Implemented
        //Without Alcohol add new product to database
        public int AddNewProduct(string name,int amount)
        {
            int Final = 0;
            try
            {
                

                string SQLAddNewProduct = "UPDATE products " +
                    "SET Amount=Amount + @amount " +
                    "WHERE ProductName=@name";

                MySqlCommand sqlCommand = new MySqlCommand(SQLAddNewProduct, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@amount", amount);

                
                MessageBox.Show("Product added succesfully");
                 Final = sqlCommand.ExecuteNonQuery();
                return Final;
            }
            catch
            {
                return Final;
            }
            finally
            {
                sqlConnection.Close();
            }
            


        }
        //Implemented
        public int AddProductToStock(string name,int amount)
        {
            int amountProduct = 0;
            amountProduct=GetAmountOfSpecificItem(name) + AddNewProduct(name, amount);

            return amountProduct;
        }

        //Implemented
        //Add new loan product
        public int AddLoanProduct(string ProductName,decimal price)
        {
            string sqlStatement = $"INSERT INTO products (ProductName, Price, ProductType, IsAlcohol, IsLoaned, Amount) " +
                $"VALUES('{ProductName}', '{price}', 'LOAN', '0', '0', 1);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

            sqlConnection.Open();

            int NewLoanProduct;

            NewLoanProduct = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Product added succesfully");
            return NewLoanProduct;

           

        }
        #endregion

        #region Commented Methods

        //Not Implemented
        //Get visitor by UserID
        //public string GetVisitorByUserID(int userID)
        //{
        //    string VisitorFullName = "";

        //    string SqlGetVisitorByUserID = "SELECT UserFirstName,UserLastName " +
        //        "FROM visitor " +
        //        "WHERE UserID=@GivenUserID";

        //    MySqlCommand VisitorByUserID = new MySqlCommand(SqlGetVisitorByUserID, sqlConnection);

        //    VisitorByUserID.Parameters.AddWithValue("@GivenUserID", userID);
        //    MySqlDataReader readerVisitorByUserID = VisitorByUserID.ExecuteReader();

        //    while (readerVisitorByUserID.Read())
        //    {
        //        VisitorFullName += (Convert.ToString("First name: " + readerVisitorByUserID[0]) + " \n Last name " +
        //         Convert.ToString(readerVisitorByUserID[1]));

        //    }
        //    readerVisitorByUserID.Close();
        //    return VisitorFullName;
        //}

        ////Not implemented
        ////Get Visitor by Name
        //public string GetVisitorByName(string VisitorName)
        //{
        //    string VisitorInfo = "";

        //    string SqlGetVisitorByName = "SELECT UserID,UserFirstName,UserLastName " +
        //        "FROM visitor " +
        //        "WHERE UserID=@GivenVisitorName";

        //    MySqlCommand VisitorByName = new MySqlCommand(SqlGetVisitorByName, sqlConnection);

        //    VisitorByName.Parameters.AddWithValue("@GivenVisitorName", VisitorName);
        //    MySqlDataReader readerVisitorByName = VisitorByName.ExecuteReader();

        //    while (readerVisitorByName.Read())
        //    {
        //        VisitorInfo += (Convert.ToString("User id " + readerVisitorByName[0]) + "First name: " +
        //         Convert.ToString(readerVisitorByName[1]) + " Last name:" +
        //         Convert.ToString(readerVisitorByName[2]));


        //    }
        //    readerVisitorByName.Close();
        //    return VisitorInfo;
        //}
        ////Not implemented
        //// Get Visitors by Transaction ID who bought product 
        //public List<string> GetVisitorByTransIDBoughtProduct(int TransID)
        //{
        //    List<string> ListVisitorsBoughtByTransID = new List<string>();


        //    string SqlGetVisitorBoughtByTransID = "SELECT BuyProduct.TransactionID,BuyProduct.UserID,BuyProduct.ProductID,Products.ProductName,Products.ProductType" +
        //        "FROM Products  JOIN BuyProduct On(Product.ProductID=BuyProduct.ProductID" +
        //        "WHERE BuyProduct.TransactionID=@GivenTransID;";

        //    MySqlCommand VisitorsBoughtByTransID = new MySqlCommand(SqlGetVisitorBoughtByTransID, sqlConnection);

        //    VisitorsBoughtByTransID.Parameters.AddWithValue("GivenTransID", TransID);

        //    MySqlDataReader ReaderVisitorsBought = VisitorsBoughtByTransID.ExecuteReader();

        //    while (ReaderVisitorsBought.Read())
        //    {

        //        ListVisitorsBoughtByTransID.Add(Convert.ToString(ReaderVisitorsBought[0]) + "  User ID:" +
        //            Convert.ToString(ReaderVisitorsBought[1]) + " Product ID:" +
        //            Convert.ToString(ReaderVisitorsBought[2]) + " Product Name:" +
        //            Convert.ToString(ReaderVisitorsBought[3]) + " Product Type:");

        //    }
        //    ReaderVisitorsBought.Close();

        //    return ListVisitorsBoughtByTransID;


        //}

        ////NotImplemented
        //// Get Visitors by ID who  Loaned
        //public List<string> GetVisitorByIDLoanedtProduct(int UserID)
        //{
        //    List<string> ListVisitorsLoanedByID = new List<string>();


        //    string SqlGetVisitorLoanedById = "SELECT LoanProduct.TransactionID,LoanProduct.UserID,LoanProduct.ProductID,Products.ProductName,LoanProduct.LoanDate,LoanProduct.ReturnDate,LoanProduct.IsDamaged" +
        //        "FROM LoanProduct  JOIN Products On(LoanProduct.ProductID=Products.ProductID) " +
        //        "WHERE LoanProduct.UserID=@GivenUserID; ";


        //    MySqlCommand VisitorsLoanedById = new MySqlCommand(SqlGetVisitorLoanedById, sqlConnection);

        //    VisitorsLoanedById.Parameters.AddWithValue("GivenUserID", UserID);

        //    MySqlDataReader ReaderVisitorsLoaned = VisitorsLoanedById.ExecuteReader();

        //    while (ReaderVisitorsLoaned.Read())
        //    {

        //        ListVisitorsLoanedByID.Add(Convert.ToString(ReaderVisitorsLoaned[0]) + "  User ID:" +
        //            Convert.ToString(ReaderVisitorsLoaned[1]) + " Product ID:" +
        //            Convert.ToString(ReaderVisitorsLoaned[2]) + " Product Name:" +
        //            Convert.ToString(ReaderVisitorsLoaned[3]) + " Loan Date:" +
        //            Convert.ToString(ReaderVisitorsLoaned[4]) + " Return Date :" +
        //            Convert.ToString(ReaderVisitorsLoaned[5]) + " Damaged:");


        //    }
        //    ReaderVisitorsLoaned.Close();

        //    return ListVisitorsLoanedByID;


        //}

        ////Not implemeteded
        //// Get Visitors by Transaction ID who loan product
        //public List<string> GetVisitorByTransIDLoanedtProduct(int TransID)
        //{
        //    List<string> ListVisitorsLoanedByTransID = new List<string>();


        //    string SqlGetVisitorLoanedByTransID = "SELECT LoanProduct.TransactionID,LoanProduct.UserID,LoanProduct.ProductID,Products.ProductName,LoanProduct.LoanDate,LoanProduct.ReturnDate,LoanProduct.IsDamaged" +
        //        "FROM LoanProduct  JOIN Products On(LoanProduct.ProductID=Products.ProductID) " +
        //        "WHERE LoanProduct.TransactionID=@GivenTransID; ";


        //    MySqlCommand VisitorsLoanedByTransID = new MySqlCommand(SqlGetVisitorLoanedByTransID, sqlConnection);

        //    VisitorsLoanedByTransID.Parameters.AddWithValue("GivenTransID", TransID);

        //    MySqlDataReader ReaderVisitorsLoaned = VisitorsLoanedByTransID.ExecuteReader();

        //    while (ReaderVisitorsLoaned.Read())
        //    {

        //        ListVisitorsLoanedByTransID.Add(Convert.ToString(ReaderVisitorsLoaned[0]) + "  User ID:" +
        //            Convert.ToString(ReaderVisitorsLoaned[1]) + " Product ID:" +
        //            Convert.ToString(ReaderVisitorsLoaned[2]) + " Product Name:" +
        //            Convert.ToString(ReaderVisitorsLoaned[3]) + " Loan Date:" +
        //            Convert.ToString(ReaderVisitorsLoaned[4]) + " Return Date :" +
        //            Convert.ToString(ReaderVisitorsLoaned[5]) + " Damaged:");


        //    }
        //    ReaderVisitorsLoaned.Close();

        //    return ListVisitorsLoanedByTransID;

        //}

        #endregion

        #region Form1 & GeneralInformation
        //Implemented
        // to know how many visitors are there
        public int GetAllVisitors()
        {
            try
            {
                string SqlGetAllVisitors = "SELECT MAX(UserID) " +
                    "FROM visitor;";

                MySqlCommand AllVisitors = new MySqlCommand(SqlGetAllVisitors, sqlConnection);
                sqlConnection.Open();
                int AllVisitorNumebrs = Convert.ToInt32(AllVisitors.ExecuteScalar());

                return AllVisitorNumebrs;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        //Implemented
        //Number of available camping spots
        public int NumberOfAvailableCampingSpots()
        {

            try
            {
                string SqlAvailableCampingSpots = "SELECT COUNT(CampID) " +
                    "FROM camping " +
                    "WHERE Status='0';";
                MySqlCommand NumberOfAvailableCampingSpots = new MySqlCommand(SqlAvailableCampingSpots, sqlConnection);
                sqlConnection.Open();
                int AvailableCampingSpots = Convert.ToInt32(NumberOfAvailableCampingSpots.ExecuteScalar());

                return AvailableCampingSpots;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //Implemented
        //Get number of ticket sold
        public double GetNumberOfTicketSold()
        {
            try
            {
                string SqlGetNumberOfTicketSold = "SELECT SUM(ticket.Amount) " +
                    "FROM visitor LEFT JOIN ticket on(visitor.UserID=ticket.UserID)" +
                    "WHERE visitor.IsPaid='1';";

                MySqlCommand GetNumberOfTicket = new MySqlCommand(SqlGetNumberOfTicketSold, sqlConnection);
                sqlConnection.Open();
                double NumberOfTicket = Convert.ToDouble(GetNumberOfTicket.ExecuteScalar());

                return NumberOfTicket;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Implemented
        //Get profit of tickets
        public double GetEventTicketProfit()
        {
            try
            {
                string SqlGetTicketProfit = "SELECT ticket.Price * COUNT(ticket.UserID) " +
                "FROM ticket ";
              
             
                MySqlCommand GetProfitTicket = new MySqlCommand(SqlGetTicketProfit, sqlConnection);
                sqlConnection.Open();
                double ProfitTicket = Convert.ToDouble(GetProfitTicket.ExecuteScalar());

                return ProfitTicket;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        //Implemented
        //CHECK SQL STATEMENT
        //Get profit of sold products
        public double GetProductsProfit()
        {
            try
            {
                string SqlGetProductsProfit = "SELECT SUM(products.Price * buyproduct.Amount)" +
                "FROM products RIGHT JOIN buyproduct ON(products.ProductID=buyproduct.ProductID);"; 
                
                MySqlCommand GetProfitProductSold = new MySqlCommand(SqlGetProductsProfit, sqlConnection);
                sqlConnection.Open();
                double ProfitProduct = Convert.ToDouble(GetProfitProductSold.ExecuteScalar());

                return ProfitProduct;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Not Implemented
        //CHECK SQL STATEMENT
        //Get profit of loaned products
        public double GetLoansProfit()
        {
            try
            {
                string SqlGetLoansProfit = "SELECT products.Price * loanproduct.ProductID)" +
                "FROM products LEFT JOIN loanproduct ON(products.ProductID=loanproduct.ProductID);";
                MySqlCommand GetProfitLoansSold = new MySqlCommand(SqlGetLoansProfit, sqlConnection);
                sqlConnection.Open();
                double ProfitLoans = Convert.ToDouble(GetProfitLoansSold.ExecuteScalar());

                return ProfitLoans;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        
        //Implemented
        public double GetTotalProfit()
        {
            double totalProfit = 0;
            try
            {
                totalProfit = GetProductsProfit() + GetEventTicketProfit() + GetLoansProfit();
                sqlConnection.Open();
                return totalProfit;
            }
            catch
            {
                return totalProfit;
            }
            finally
            {
                sqlConnection.Close();
            }
           
            
        }

        //Implemented
        //Get Number of Sold Products
        public double GetAllNumberOfSoldProducts()
        {

            try
            {
                string SqlGetAmountSoldProducts = "SELECT SUM(Amount) " +
                    "FROM buyproduct;";

                MySqlCommand AmountSoldProducts = new MySqlCommand(SqlGetAmountSoldProducts, sqlConnection);
                sqlConnection.Open();

                double SoldProducts = Convert.ToDouble(AmountSoldProducts.ExecuteScalar());

                return SoldProducts;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        //Implemented
        //Get number of Loaned Products
        public double GetAllNumberOfLoanedProducts()
        {

            try
            {
                string SqlGetAmountLoanedProducts = "SELECT COUNT(ProductID) " +
                    "FROM loanproduct;";

                MySqlCommand AmountLoanedProduct = new MySqlCommand(SqlGetAmountLoanedProducts, sqlConnection);
                sqlConnection.Open();
                double LoanedProducts = Convert.ToDouble(AmountLoanedProduct.ExecuteScalar());

                return LoanedProducts;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

       
        }
        //Implemented
        //Get number of visitors who checked in from event
        public double GetVisitorCheckedInEvent()
        {
            try
            {
                string SqlGetVisitorEventCheckedIn = "SELECT Count(UserID) " +
                    "FROM visitor " +
                    "WHERE CheckedInEvent='1'; ";
                MySqlCommand GetEventCheckedInVisitors = new MySqlCommand(SqlGetVisitorEventCheckedIn, sqlConnection);
                sqlConnection.Open();
                double NumberOfEventCheckedInVisitors = Convert.ToDouble(GetEventCheckedInVisitors.ExecuteScalar());

                return NumberOfEventCheckedInVisitors;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        //Implemented
        //Get number of visitors who checked out from event
        public double GetVisitorCheckedOutEvent()
        {
            try
            {
                string SqlGetVisitorEventCheckedOut = "SELECT Count(UserID) " +
                    "FROM visitor " +
                    "WHERE CheckedInEvent='0'; ";
                MySqlCommand GetEventCheckedOutVisitors = new MySqlCommand(SqlGetVisitorEventCheckedOut, sqlConnection);
                sqlConnection.Open();
                double NumberOfEventCheckedOutVisitors = Convert.ToDouble(GetEventCheckedOutVisitors.ExecuteScalar());

                return NumberOfEventCheckedOutVisitors;
            }
            catch
            {
                return 0;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion
    }
}
