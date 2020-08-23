using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_133HeP.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFactureDate) : base (name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string ToString()
        {
            return $"Name: {Name} (Used) Price: $ {Price} (Manufacture date: {ManuFactureDate.ToString("dd/MM/yyyy")})";
        }
    }
    
}
