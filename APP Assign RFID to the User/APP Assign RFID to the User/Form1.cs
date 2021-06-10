using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace APP_Assign_RFID_to_the_User
{
    public partial class Form1 : Form
    {
        public string RFIDcode;
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
                RFIDreader.Open();
            }
            catch (PhidgetException)
            {
                MessageBox.Show("Error appeared while trying to read RFID");
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
        private void RFIDReaderAttach(object sender, AttachEventArgs e)
        {

        }
        private void RFIDReaderDetach(object sender, DetachEventArgs e)
        {

        }
        private void ShowInfoOnTagDetected(object sender, RFIDTagEventArgs e)
        {
            try
            {
                RFIDcode = e.Tag;
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

        private void button3_Click(object sender, EventArgs e)
        {
     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RFIDcode!=null)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(textBox1.Text);
                connection.Open();
                MySqlCommand command = new MySqlCommand($"UPDATE visitor SET rfidID = '{RFIDcode}' WHERE UserID = {userID};", connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                connection.Close();

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
                label4.Visible = true;
                RFIDcode = null;
            }
        }
    }
}
