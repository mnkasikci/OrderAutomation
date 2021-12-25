using OrderAutomation.Global;
using OrderAutomation.Models;
using System;

public class Order
{
    public DateTime Date;
    public OrderStatus status;
    public OrderDetail OrderDetail;

    public decimal CalcTax() =>  OrderDetail.CalcSubTotal() * 0.18M;
    public decimal CalcTotal => OrderDetail.CalcSubTotal() + CalcTax();

}
