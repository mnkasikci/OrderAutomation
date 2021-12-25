using Dapper;
using OrderAutomation.Models;
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
                order.Id = db.QueryFirst(sp, dp, commandType: CommandType.StoredProcedure);
            }
        }

        private static DataTable AddItems(IEnumerable<Item> orderItems)
        {
            DataTable table = new();
            var properties = typeof(Item).GetProperties();

            foreach (var item in properties)
            {
                table.Columns.Add(item.Name, item.PropertyType);
            }

            foreach (var item in orderItems)
            {
                var parameters = new List<object>();
                var valueProperties = item.GetType().GetRuntimeProperties();
                foreach (var prop in valueProperties)
                {
                    var p = prop.GetValue(item);
                    parameters.Add(p);
                }
                table.Rows.Add(parameters.AsList());
            }
            return table;
        }

        internal static void SavePayment(Check check)
        {
            var sp = "usp_SaveCheckPayment";
            DynamicParameters dp = new();
            dp.Add("BankId", check.BankId);
            dp.Add("Name", check.Name);
            dp.Add("Id", check.Order.Id);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);
        }
        internal static void SavePayment(Credit credit)
        {
            var sp = "usp_SaveCreditCardPayment";

            DynamicParameters dp = new();
            dp.Add("CardNumber", credit.CardNumber);
            dp.Add("ExpDate", credit.ExpDate);
            dp.Add("ExpDate", credit.ExpDate);
            dp.Add("NameOnCard", credit.NameOnCard);
            dp.Add("Id", credit.Order.Id);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);

        }

        internal static void SavePayment(Cash cash)
        {
            var sp = "usp_SaveCashPayment";
            DynamicParameters dp = new();
            dp.Add("Id",cash.Order.Id);
            dp.Add("CashTendered", cash.CashTendered);
            dp.Add("Change", cash.Change);

            using IDbConnection db = new SqlConnection(DBConnection.STR);
            db.Execute(sp, dp, commandType: CommandType.StoredProcedure);

        }
    }
}
