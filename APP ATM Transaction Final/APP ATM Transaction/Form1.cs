using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_ATM_Transaction
{
    public partial class Form1 : Form
    {
        FileStream fs;
        MySqlConnection connection = new MySqlConnection("server=studmysql01.fhict.local;" + "database=dbi393800;" + "user id=dbi393800;" + "password=ralia12345;");
        FileSystemWatcher fileSystemWatcher;
        public FileInfo testing;
        public Form1()
        {
            InitializeComponent();

            fileSystemWatcher = new FileSystemWatcher();
            //That's the path, it has to be changed if used on other PC
            fileSystemWatcher.Path = @"C:\Users\mateu\Desktop\prop\GUI\APP ATM Transaction - Copy";
            //fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.EnableRaisingEvents = true;
            
        }
        
        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                FileInfo testing = new FileInfo(e.FullPath);
                StreamReader sr;
                SelectedFile file;
                file = new SelectedFile();
                fs = new FileStream(testing.FullName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                file.ProcessFile(fs, sr);
                fs.Close();
                //start date and end date format 
                string sqlStartDate = $"{file.StartDate.Year}-{file.StartDate.Month}-{file.StartDate.Day} {file.StartDate.Hour}:{file.StartDate.Minute}:{file.StartDate.Second}";
                string sqlEndDate = $"{file.EndDate.Year}-{file.EndDate.Month}-{file.EndDate.Day} {file.EndDate.Hour}:{file.EndDate.Minute}:{file.EndDate.Second}";
                string query;
                MySqlCommand command;
                int executeQuery;

                for (int i = 0; i < file.NoOfTransactions; i++)
                {
                    connection.Open();
                    query = $@"INSERT INTO atm (IBAN, TransStartDate, TransEndDate, UserID, Amount) VALUES ('{file.Iban}', '{sqlStartDate}', '{sqlEndDate}', {file.tempList[i].Item1}, {file.tempList[i].Item2});";
                    command = new MySqlCommand(query, connection);
                    executeQuery = command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Log file with transaction(s) was added to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
            finally
            {
                fs.Close();
                connection.Close();
            }
        }

 
    }
}
