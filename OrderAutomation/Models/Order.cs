using OrderAutomation.Global;
using System;
namespace OrderAutomation.Models
{

    public class Order
    {
        public Order(OrderDetail od, DateTime date, Customer customer)
        {
            Customer = customer;
            OrderDetail = od;
            Date = date;
        }
        public DateTime Date { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public Customer Customer { get; set; }
        public int Id{get; set;}

        public decimal CalcTax() => OrderDetail.CalcSubTotal() * 0.18M;
        public decimal CalcTotal() => OrderDetail.CalcSubTotal() + CalcTax();

    }
}