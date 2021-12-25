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
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string ExpDate { get; set; }

        public Credit(Order order,string cardNumber,string nameOnCard,string expDate) : base( order)
        {
            CardNumber = cardNumber;
            NameOnCard = nameOnCard;
            ExpDate = expDate;
        }

        public new void ProcessPayment()
        {
            base.ProcessPayment();
            DBHelper.SavePayment(this);
        }
    }
    public class Cash : Payment
    {
        public decimal CashTendered { get; set; }

        public Cash(Order order,decimal cashTendered) : base( order)
        {
            CashTendered = cashTendered;
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
        public string Name { get; set; }
        public string BankId { get; set; }


        public Check(Order order,string name,string bankId) : base( order)
        {
            Name = name;
            BankId = bankId;
        }

        public new void ProcessPayment()
        {
            base.ProcessPayment();
            DBHelper.SavePayment(this);
        }
    }

}
