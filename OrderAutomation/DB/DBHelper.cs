using Dapper;
using OrderAutomation.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrderAutomation.DB
{
    public static class DBHelper
    {
        public static IEnumerable<Urun> UrunListesiniAl()
        {
            var sp = "usp_GetItemList";
            using (IDbConnection db = new SqlConnection(DBConnection.STR))
            {
                var result = db.Query<Urun>(sp,commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
