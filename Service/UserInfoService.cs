using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using Service.Common;
using Model;

namespace Service
{
    public class UserInfoService
    {
        public bool CheckRecord(UserInfoModel mode)
        {
            using (var conn = DapperConnection.GetDHAConnection())
            {
                string _Sql = "SELECT COUNT(*) FROM userinfo WHERE userID = @userID AND password = @password";
                return conn.Query<int>(_Sql, mode).Single() > 0;
            }
        }
        public bool CheckRecord(string UID, string PSW)
        {
            using (var conn = DapperConnection.GetDHAConnection())
            {
                string _Sql = "SELECT COUNT(*) FROM userinfo WHERE userID = @userID AND password = @password";
                return conn.Query<int>(_Sql, new { userID = UID, password = PSW }).Single() > 0;
            }
        }
    }
}
