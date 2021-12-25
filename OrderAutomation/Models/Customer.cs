using OrderAutomation.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
    public class Customer : User
    {
        public string Address { get; set; }
        
    }
    public class Admin : User
    {

    }
}
