using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Models
{
    public class OrderDetail
    {
        public List<Item> Items = new ();
        public decimal CalcSubTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
        public decimal CalcWeight()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Weight * item.Quantity;
            }
            return total;
        }
    }
}
