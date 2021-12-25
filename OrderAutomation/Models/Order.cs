using OrderAutomation.Global;
using System;
namespace OrderAutomation.Models
{

    public class Order
    {
        public Order(OrderDetail od, DateTime date,Customer customer)
        {
            Customer = customer;
            OrderDetail = od;
            Date = date;
            Status = OrderStatus.BeingProcessed;
        }
        public DateTime Date;
        public OrderStatus Status;
        public OrderDetail OrderDetail;
        public Customer Customer;

        public decimal CalcTax() => OrderDetail.CalcSubTotal() * 0.18M;
        public decimal CalcTotal => OrderDetail.CalcSubTotal() + CalcTax();

    }
}