using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation
{
   public class shophingclass
    {

        public int ShoppingID { get; set; }
        public decimal ShoppingTaxfreePrice { get; set; }
        public decimal ShoppingTaxwithPrice { get; set; }

        public void CalcTax()
        {
            ShoppingTaxwithPrice += ShoppingTaxfreePrice * 18 / 100+ShoppingTaxfreePrice;

        }

    }
}
