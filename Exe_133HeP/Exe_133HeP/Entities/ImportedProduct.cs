using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_133HeP.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        

        public override string ToString()
        {
            return $"Name: {Name} Price: $ {Price} (Customs Fee: ${CustomsFee}";
        }
    }
}
