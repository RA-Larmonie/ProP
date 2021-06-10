using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Stand
{
    class Shop
    {
        private string loanProdName;
        private double loanProdPrice;
        private double total;

        public Shop(string prodName, double prodPrice)
        {
            this.loanProdName = prodName;
            this.loanProdPrice = prodPrice;
            this.total = +prodPrice;
        }

        public string ProdName { get { return this.loanProdName; } }


        public double ProdPrice { get { return this.loanProdPrice; } }

        public double PTotal { get { return this.total; } }
    }
}
