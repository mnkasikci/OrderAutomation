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
        public int Id;
        public string UserName;
        public string Password;
        public string Name;
    }
    public class Customer : User
    {
        public string Address;
        
    }
    public class Admin : User
    {

    }
}
