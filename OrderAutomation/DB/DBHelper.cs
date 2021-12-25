using Dapper;
using OrderAutomation.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrderAutomation.DB
{
    public static class DBHelper
    {
        public static IEnumerable<Item> UrunListesiniAl()
        {
            var sp = "usp_GetItemList";
            using (IDbConnection db = new SqlConnection(DBConnection.STR))
            {
                var result = db.Query<Item>(sp,commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
