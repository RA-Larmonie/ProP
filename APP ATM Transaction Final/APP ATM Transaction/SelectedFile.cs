using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace APP_ATM_Transaction
{
    class SelectedFile
    {
        public string Iban { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Tuple<int, string>> tempList { get; set; }
        public int NoOfTransactions { get; set; }

        public SelectedFile()
        {
            tempList = new List<Tuple<int, string>>();
        }

        public void ProcessFile(FileStream f, StreamReader sr)
        {
            string temp;
            Iban = sr.ReadLine();
            string s = sr.ReadLine();
            StartDate = DateTime.ParseExact(s, "yyyy/MM/dd/HH:mm:ss", CultureInfo.InvariantCulture);
            s = sr.ReadLine();
            EndDate = DateTime.ParseExact(s, "yyyy/MM/dd/HH:mm:ss", CultureInfo.InvariantCulture);
            NoOfTransactions = int.Parse(sr.ReadLine());
            for (int i = 0; i < NoOfTransactions; i++)
            {
                temp = sr.ReadLine();
                tempList.Add(new Tuple<int, string>(int.Parse(temp.Split(' ')[0]), temp.Split(' ')[1].Replace(',', '.')));
            }
        }
    }
}