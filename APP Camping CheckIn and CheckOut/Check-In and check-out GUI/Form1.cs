using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_In_and_check_out_GUI
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        RFID RFIDreader;
        public Form1()
        {
            InitializeComponent();
            plCheckOut.Visible = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the start position of the form to the center of the screen.
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                RFIDreader.Open();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Error Appeard while connecting the reader");
                label6.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void RFIDReaderAttach(object sender, AttachEventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Green;
            label6.Text = "Connected";
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
        private void RFIDReaderDetach(object sender, DetachEventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            label6.Text = "Not Connected";
        }
        #endregion

        #region CheckIn & CheckOut
        private void btnInConfirm_Click(object sender, EventArgs e)
        {

                    string rfidID = tbTicketNo.Text;
                    connection.Open();
                    string query = $@"SELECT UserFirstName,UserLastName, UserID, CheckedInCamping, CheckedInEvent FROM visitor WHERE rfidID = '{rfidID}';";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) //visitor is in database
                    {
                        reader.Read();
                        string ID =  $"{reader[2]}"; // UserID 
                        reader.Close();

                        if (IsPersonInCampSpot(Convert.ToInt32(ID)) == 1) // if person has camping spot assigned
                        {
                            query = $@"UPDATE Visitor SET CheckedInCamping = 1 WHERE rfidID = '{rfidID}';";
                            command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Checked in person with ID " + ID);
                        }
                        else if (IsPersonInCampSpot(Convert.ToInt32(ID)) == -1) // if person has NO camping spot assigned
                        {
                            MessageBox.Show($"Person with ID {ID} has no camping spot bought.");
                            connection.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("There is no such person is database");
                    }
                    connection.Close();
                
        }
        private int IsPersonInCampSpot(int id) // method that checks if the person has camping spot assigned
        {
            int IDOfBuyer = SearchForBuyer(id) == 1 ? id : SearchForBuyer(id); // this is ID of person that bought camping
            string query = $"SELECT UserID,CampID FROM assigncamping WHERE UserID = {IDOfBuyer};";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //there is such Visitor with camping bought, returns 1
            if (reader.HasRows)
            {
                reader.Close();
                return 1;
            }
            //there is no such buyer, returns -1
            else
            {
                reader.Close();
                return -1;
            }
        }
        private int SearchForBuyer(int id) // method that looks for buyer of camping 
        {
            
            string query = $"SELECT CampID FROM assigncamping WHERE UserID = {id};";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if(reader.HasRows) //there is such campID with UserID equal to id (buyer), returns id
            {
                reader.Close();
                return id;
            }
            else // reader has no rows so there is no such buyer, returns 0
            {
                reader.Close();
                return 0;
            }
            
        }

        private void btnOutConfirm_Click(object sender, EventArgs e)
        {
  
                    string rfidID = tbTicketNo.Text;
                    connection.Open();
                    string query = $@"SELECT UserFirstName,UserLastName, UserID, CheckedInCamping, CheckedInEvent FROM visitor WHERE rfidID = '{rfidID}';";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) //visitor is in database
                    {
                        reader.Read();
                        string thisID = $"{reader[2]}"; //index of UserID is 2
                        reader.Close();

                        query = $@"UPDATE Visitor SET CheckedInCamping = 0 WHERE rfidID = '{rfidID}';";
                        command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Checked out person with ID " + thisID);
                    }
                    else
                    {
                        MessageBox.Show("There is no such person is database");
                    }
                    connection.Close();
        }

        #endregion
    }
}
