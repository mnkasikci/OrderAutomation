using OrderAutomation.DB;
using System;

namespace OrderAutomation.Models
{
    public abstract class Payment
    {
        public Payment(Order order)
        {
            Order = order;
        }

        public Order Order;
        public void ProcessPayment()
        {
            DBHelper.SaveOrder(Order);
        }
        
    }
    public class Credit : Payment
    {
        public string CardNumber;
        public string NameOnCard;
        public string ExpDate;

        public Credit(Order order) : base( order)
        {
        }

        public new void ProcessPayment()
        {
            base.ProcessPayment();
            DBHelper.SavePayment(this);
        }
    }
    public class Cash : Payment
    {
        public decimal CashTendered;

        public Cash(Order order) : base( order)
        {
        }

        public decimal Change => CashTendered - this.Order.CalcTotal();

        public new void ProcessPayment()
        {
            base.ProcessPayment();
            DBHelper.SavePayment(this);
        }
    }
    public class Check : Payment
    {
        public string Name;
        public string BankId;

        public Check(Order order) : base( order)
        {
        }

        public new void ProcessPayment()
        {
            base.ProcessPayment();
            DBHelper.SavePayment(this);
        }
    }

}
