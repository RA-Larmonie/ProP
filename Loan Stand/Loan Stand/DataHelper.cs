using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Loan_Stand
{
    class DataHelper
    {
        public MySqlConnection connection;
        private user user;


        public DataHelper()
        {
            String connectionInfo = "server=studmysql01.fhict.local;" +
                                    "database=dbi393800;" +
                                    "user id=dbi393800;" +
                                    "password=ralia12345;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }






        public List<Products> GetLoanProducts()
        {
            connection.Close();
            String sql = "SELECT * FROM products WHERE ProductType = 'LOAN'";



            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Products> tempLoan;
            tempLoan = new List<Products>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();



                int productID;
                String name;
                double price;
                string type;
                Boolean damaged;

                while (reader.Read())
                {
                    productID = Convert.ToInt32(reader["ProductID"]);
                    name = Convert.ToString(reader["ProductName"]);
                    price = Convert.ToDouble(reader["Price"]);
                    type = Convert.ToString(reader["ProductType"]);
                    damaged = Convert.ToBoolean(reader["IsDamaged"]);

                    if (type == "LOAN")
                    {
                        tempLoan.Add(new Products(productID, name, price, type, damaged));
                    }
                }
            }
            catch
            {
                MessageBox.Show("error while loading the products");
            }
            finally
            {
                connection.Close();
            }
            return tempLoan;
        }




        public int AddLoanTransaction(string name, double depositCost, string description, int id, bool damaged)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
            connection.Close();

            String sql = "INSERT INTO loanproduct VALUES (@ProductID, @UserID, @LoanDate, @ReturnDate, @IsDamaged)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProductID", name);
            command.Parameters.AddWithValue("@UserID", depositCost);
            command.Parameters.AddWithValue("@LoanDate", description);
            command.Parameters.AddWithValue("@ReturnDate", id);
            command.Parameters.AddWithValue("@IsDamaged", damaged);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }



        }

        public void UpdateBalance(int id, double minusBal)
        {
            connection.Close();

            string sqlAdd = $"UPDATE visitor SET Balance = {minusBal} WHERE UserID = {id};";
            MySqlCommand cmdAdd = new MySqlCommand(sqlAdd, connection);
            connection.Open();

            object update = cmdAdd.ExecuteNonQuery();

            connection.Close();



        }

        public double GetBalance(int id)
        {
            connection.Close();
            string sqlBal = $"SELECT Balance FROM visitor WHERE UserID = {id};";
            MySqlCommand cmdBal = new MySqlCommand(sqlBal, connection);

            connection.Open();

            double bal = Convert.ToDouble(cmdBal.ExecuteScalar());


            connection.Close();

            return bal;
        }
       

        public void UpdateBalancePlus(int id, double minusBal)
        {
            connection.Close();
            string sqlBal = $"SELECT BALANCE FROM user WHERE USER_ID = {id};";
            MySqlCommand cmdBal = new MySqlCommand(sqlBal, connection);

            connection.Open();

            double bal = Convert.ToDouble(cmdBal.ExecuteScalar());

            connection.Close();

            string sqlAdd = $"UPDATE user SET BALANCE = {bal + minusBal} WHERE USER_ID = {id};";
            MySqlCommand cmdAdd = new MySqlCommand(sqlAdd, connection);
            connection.Open();

            object update = cmdAdd.ExecuteNonQuery();

            connection.Close();



        }

    }
}
