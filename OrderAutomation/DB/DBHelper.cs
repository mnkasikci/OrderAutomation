using Dapper;
using OrderAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace OrderAutomation.DB
{
    public static class DBHelper
    {
        public static IEnumerable<Item> UrunListesiniAl()
        {
            var sp = "usp_GetItemList";
            using (IDbConnection db = new SqlConnection(DBConnection.STR))
            {
                var result = db.Query<Item>(sp, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        internal static void SaveOrder(Order order)
        {
            var sp = "usp_SaveOrder";

            DynamicParameters dp = new();

            dp.Add("Date", order.Date);
            dp.Add("TotalAmount", order.CalcTotal());
            dp.Add("TotalTax", order.CalcTax());
            dp.Add("CustomerId", order.Customer.Id);
            dp.Add("OrderWeight", order.OrderDetail.CalcWeight());

            var listItems = AddItems(order.OrderDetail.Items);
            dp.Add("OrderItems", listItems.AsTableValuedParameter("[dbo].[udt_ListItems]"));

            using (IDbConnection db = new SqlConnection(DBConnection.STR))
            {
                order.Id = db.QueryFirst<int>(sp, dp, commandType: CommandType.StoredProcedure);
            }
        }

        private static DataTable AddItems(IEnumerable<Item> orderItems)
        {
            DataTable table = new();

            table.Columns.Add("Id",typeof(int));
            table.Columns.Add("Quantity",typeof(int));
            
            foreach (var item in orderItems)
            {
                var parameters = new List<object>();
                parameters.Add(item.Id);
                parameters.Add(item.Quantity);
                table.Rows.Add(parameters.ToArray());
            }
            return table;
        }

        internal static void SavePayment(Check check)
        {
            var sp = "usp_SaveCheckPayment";
            DynamicParameters dp = new();
            dp.Add("CustomerId", check.Order.Customer.Id);
            dp.Add("BankId", check.BankId);
            dp.Add("Name", check.Name);
            dp.Add("OrderId", check.Order.Id);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);
        }
        internal static void SavePayment(Credit credit)
        {
            var sp = "usp_SaveCreditCardPayment";

            DynamicParameters dp = new();
            dp.Add("CustomerId", credit.Order.Customer.Id);
            dp.Add("CardNumber", credit.CardNumber);
            dp.Add("ExpDate", credit.ExpDate);
            dp.Add("NameOnCard", credit.NameOnCard);
            dp.Add("OrderId", credit.Order.Id);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);

        }

        internal static void SavePayment(Cash cash)
        {
            var sp = "usp_SaveCashPayment";

            DynamicParameters dp = new();
            dp.Add("CustomerId", cash.Order.Customer.Id);
            dp.Add("OrderId", cash.Order.Id);
            dp.Add("CashTendered", cash.CashTendered);
            dp.Add("Change", cash.Change);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);

        }
    }
}
