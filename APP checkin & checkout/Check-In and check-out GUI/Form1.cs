using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace Check_In_and_check_out_GUI
{
    public partial class Form1 : Form
    {
        public MySqlConnection connection;
        RFID RFIDreader;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            //database connection
            string dbConnectionInfo;
            dbConnectionInfo = "server=studmysql01.fhict.local;user id=dbi393800;database=dbi393800;password=ralia12345;";
            connection = new MySqlConnection(dbConnectionInfo);
            #region Open connection MySql and RFID initialization
            try
            {
                connection.Open();
                RFIDreader = new RFID();
                RFIDreader.Attach += RFIDReaderAttach;
                RFIDreader.Detach += RFIDReaderDetach;
                RFIDreader.Tag += this.ShowInfoOnTagDetected;
                RFIDreader.TagLost += this.TagLost;
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Error appeared while trying to read RFID");
                label6.ForeColor = System.Drawing.Color.Red;
            }
            catch (MySqlException msq)
            {
                MessageBox.Show("Could not connect to database, error message: " + msq.Message);
            }
            finally
            {
                connection.Close();
            }
            #endregion
        }
        #region Visual additions
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCheckedIn.Checked)
            {
                plCheckIn.Visible = true;
                plCheckOut.Visible = false;
                plCheckIn.Location = new Point(-3, 56);
                plCheckOut.Location = new Point(-3, 56);
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCheckedOut.Checked)
            {
                plCheckIn.Visible = false;
                plCheckOut.Visible = true;
                plCheckIn.Location = new Point(-3, 56);
                plCheckOut.Location = new Point(-3, 56);
            }
        }
        #endregion

        #region RFID
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RFIDreader.Open();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Error appeard while connecting the reader");
                label6.ForeColor = System.Drawing.Color.Red;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error occured, please check if RFID scanner is connected to the PC");
                label6.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void RFIDReaderAttach(object sender, AttachEventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Green;
            label6.Text = "Connected";
        }
        private void RFIDReaderDetach(object sender, DetachEventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Text = "Not Connected";
        }
        private void ShowInfoOnTagDetected(object sender, RFIDTagEventArgs e)
        {
            try
            {
                tbTicketNo.Text = e.Tag;
                textBox1.Text = e.Tag;
            }
            catch (PhidgetException pe)
            {
                MessageBox.Show(pe.Message);
            }
        }
        private void TagLost(object sender, RFIDTagLostEventArgs e)
        {
            connection.Close();
        }
        #endregion

        #region Check-in and check-out 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label9.Visible = false;
                string rfid = tbTicketNo.Text;
                    connection.Open();
                    string sqlStatement = $"SELECT UserFirstName, UserLastName, CheckedInEvent FROM visitor WHERE rfidID = '{rfid}';";
                    MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    connection.Close();
                    connection.Open();
                    command = new MySqlCommand($"UPDATE visitor SET CheckedInEvent = 1 WHERE rfidID = '{rfid}';", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                


             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
                label8.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                label8.Visible = false;
                string rfid = tbTicketNo.Text;
                    connection.Open();
                    string sqlStatement = $"SELECT UserFirstName, UserLastName, CheckedInEvent, Balance FROM visitor WHERE rfidID = '{rfid}';";
                    MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    
                    reader.Read();
                connection.Close();
                connection.Open();
                MySqlCommand command2 = new MySqlCommand($"SELECT UserID, ReturnDate from loanproduct WHERE rfidID = '{rfid}';", connection);
                MySqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                if (reader2.HasRows == false || reader2[1].ToString() != "")
                {

                    connection.Close();
                    connection.Open();
                    command = new MySqlCommand($"UPDATE visitor SET CheckedInEvent = false, Balance = 0 WHERE rfidID = '{rfid}';", connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    label9.Visible = true;
                   // label9.Text += " Cash to return: " + amountToReturn;

                }
                else
                {
                    MessageBox.Show("This person did not return loaned product.");
                }
                    

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
                
            }
        }
        #endregion
        private bool CheckAge()
        {
            int age = 0;
            string rfid = tbTicketNo.Text;
            string sql = $"SELECT DATEDIFF(DATE_FORMAT(CURRENT_DATE,'%Y-%m-%d'), DateOfBirth) FROM visitor WHERE rfidID = '{rfid}';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                age = (Convert.ToInt32(reader[0]) / 365);
            }
            connection.Close();

            if (age >= 18)
            {
                return true;
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string rfid = tbTicketNo.Text;
                connection.Open();
                MySqlCommand command = new MySqlCommand($"UPDATE Visitor SET DateOfBirth = '2020-01-01' WHERE rfidID = '{rfid}';", connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                connection.Close();
                label7.Text = "This is a minor.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbTicketNo_TextChanged(object sender, EventArgs e)
        {
            if(CheckAge())
            {
                label7.Text = "This is an adult.";
            }
            else
            {
                label7.Text = "This is a minor.";
            }
        }
    }
}
