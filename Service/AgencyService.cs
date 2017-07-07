using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data;
using Service.Common;

namespace Service
{
    public class AgencyService
    {
        public bool CheckRecord(string agencyCode)
        {
            using (var conn = DapperConnection.GetDHAConnection())
            {
                string _Sql = "SELECT COUNT(*) FROM Agency WHERE  AgencyCode = @AgencyCode";
                return conn.Query<int>(_Sql, new { AgencyCode = agencyCode }).Single() > 0;
            }
        }
    }
}
