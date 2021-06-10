using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Stand
{
    class Products
    {

        private int productID;
        private String name;
        private double price;
        private string type;
        private bool damaged;

        public string Name { get { return this.name; } }
        public int ProductId { get; set; }

        public double Price { get { return this.price; } }



        public Products(int productID, String name, double price, string type, Boolean damaged)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.type = type;
            this.damaged = damaged;
        }


        public override String ToString()
        {
            return this.productID.ToString() + " - " + this.name + " - " + this.price.ToString();
        }

    }
}
