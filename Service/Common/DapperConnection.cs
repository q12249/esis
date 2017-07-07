using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Service.Common
{
    public class DapperConnection
    {
        /// <summary>
        /// 取得DB的連接字串
        /// </summary>
        /// <returns>DB連接字串</returns>
        public static string GetDHAConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["DHA"] != null)
                return ConfigurationManager.ConnectionStrings["DHA"].ToString();
            else
                return string.Empty;
        }

        public static IDbConnection GetDHAConnection()
        {
            return new SqlConnection(GetDHAConnectionString());
        }

        public static string GetSTOCK1ConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["STOCK1"] != null)
                return ConfigurationManager.ConnectionStrings["STOCK1"].ToString();
            else
                return string.Empty;
        }

        public static IDbConnection GetSTOCK1Connection()
        {
            return new OdbcConnection(GetSTOCK1ConnectionString());
        }
    }
}
