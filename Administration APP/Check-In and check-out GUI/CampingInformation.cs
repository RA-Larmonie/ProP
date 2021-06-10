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
    public partial class CampingInformation : Form
    {
        SQLDataControl sqlControl;
        public CampingInformation()
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

            }
            catch(MySqlException )
            {
                MessageBox.Show("Database connection problem");
            }

            TimerCamping.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void StartUp()
        {
            lbAvailableCamping.Items.Clear();
            lbTakenCamping.Items.Clear();

            try
            {
                tBAvailableCampSpots.Text = Convert.ToString(sqlControl.NumberOfAvailableCampingSpots());
                tBNumberOfTakenSpots.Text = Convert.ToString(sqlControl.NumberOfTakenCampingSpots());

                lbAvailableCamping.Items.Clear();
                foreach (string campingspots in sqlControl.GetListOfAvailableCampingSpots())
                {
                    lbAvailableCamping.Items.Add(campingspots).ToString();
                }
                lbTakenCamping.Items.Clear();
                foreach (string campingspots in sqlControl.GetListOfTakenCampingSpots())
                {
                    lbTakenCamping.Items.Add(campingspots);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Database connection problem");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Database is empty");
            }

           

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {

            

            int CampID = Convert.ToInt32(tBCampID.Text);

            try
            {
                LbStartDate.Text = sqlControl.GetStardDateOfCamping(CampID);
                LbEndDate.Text = sqlControl.GetEndDateOfCamping(CampID);
                int AvailableSpots = 6 - sqlControl.NumberOfBookedSpots(CampID);
                LbSpotsAvailable.Text = Convert.ToString(AvailableSpots);
                LbCampInfo.Items.Clear();
                foreach (string item in sqlControl.GetUserFirstNameCamping(CampID))
                {
                    LbCampInfo.Items.Add(item);
                }
            }
            catch(MySqlException )
            {
                LbStartDate.Text = "";
                LbEndDate.Text = "";
                LbSpotsAvailable.Text = "";
                LbCampInfo.Items.Clear();
                
                MessageBox.Show("Camp id "+CampID.ToString()+" has no bookings");
                sqlControl.Disconnect();
            }
            catch(NullReferenceException )
            {
                LbStartDate.Text = "";
                LbEndDate.Text = "";
                LbSpotsAvailable.Text = "";
                LbCampInfo.Items.Clear();
                sqlControl.Disconnect();
                MessageBox.Show("Please type a correct Camp ID");
                sqlControl.Disconnect();
            }
            catch(FormatException )
            {
                LbStartDate.Text = "";
                LbEndDate.Text = "";
                LbSpotsAvailable.Text = "";
                LbCampInfo.Items.Clear();
                sqlControl.Disconnect();
                MessageBox.Show("Please type a correct Camp ID");
                sqlControl.Disconnect();

            }


        }

        private void TimerCamping_Tick(object sender, EventArgs e)
        {
            StartUp();
        }

        private void lbAvailableCamping_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBTakenCampSpots_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbSpotsAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
