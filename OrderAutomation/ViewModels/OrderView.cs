using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.ViewModels
{
    public class OrderView
    {
       public DateTime Date { get; set; }
       public string Name { get; set; }
       public string Address { get; set; }
       public decimal TotalAmount { get; set; }
       public string Items { get; set; }
    }
}
