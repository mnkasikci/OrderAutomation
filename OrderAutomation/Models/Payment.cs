using System;

namespace OrderAutomation.Models
{
    public abstract class Payment
    {
        public Payment(Order order)
        {

            Order = order;
            Amount = Order.CalcTotal;
        }

        public Order Order;
        public decimal Amount;
        public abstract void ProcessPayment();
    }
    public class Credit : Payment
    {
        public string CardNumber;
        public string NameOnCard;
        public DateTime ExpDate;

        public Credit(Order order) : base( order)
        {
        }

        public override void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
    public class Cash : Payment
    {
        public decimal CashTendered;

        public Cash(Order order) : base( order)
        {
        }

        public decimal Change => CashTendered - Amount;

        public override void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
    public class Check : Payment
    {
        public string Name;
        public string BankId;

        public Check(Order order) : base( order)
        {
        }

        public override void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }

}
