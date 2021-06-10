using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Stand
{
    class user
    {
        private DateTime dat = new DateTime(10, 2, 5);
        private int user_id;
        private string first_name;
        private string last_name;
        private int balance;

        public int User_id { get; set; }
        public string Last_name { get; set; }
        public int Balance { get; set; }
        public string First_name { get; set; }

        public string Username { get { return this.first_name + " " + this.last_name; } }

        public user(int user_id, string first_name, string last_name, int balance)
        {
            this.User_id = user_id;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Balance = balance;
        }
    }
}
