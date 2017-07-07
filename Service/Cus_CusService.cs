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
    public class Cus_CusService
    {
        public Cus_CusModel GetRecords(Cus_CusModel mode)
        {
            using (var conn = DapperConnection.GetSTOCK1Connection())
            {
                string _Sql = "Select A.cus_nbr,A.cus_name,A.cus_tel1,A.cus_addr,A.cus_gun,A.sale_name,DTOS(A.remark7) as remark7"
                    + " FROM CUS_CUS A where (A.cus_nbr Like ?cus_nbr1? OR A.cus_name Like ?cus_nbr2? OR A.cus_tel1 Like ?cus_nbr3? OR"
                    + " A.cus_addr Like ?cus_nbr4? OR A.cus_gun Like ?cus_nbr5? OR A.sale_name Like ?cus_nbr6?) and Left(A.cus_nbr,1)='H'";
                // 第一碼為英文時,搜尋字串必須大於3碼
                if (mode.cus_nbr.Length < 3)
                {
                    byte[] bytes = Encoding.GetEncoding("Big5").GetBytes(mode.cus_nbr.Substring(0, 1));
                    if (bytes.Length <= 1) // if there is only one byte, it is ASCII code
                    {
                        _Sql += " and 1=0";
                    }
                }
                _Sql += " ORDER BY A.cus_nbr";
                return conn.Query<Cus_CusModel>(_Sql, new {
                    cus_nbr1 = mode.cus_nbr + "%",
                    cus_nbr2 = mode.cus_nbr + "%",
                    cus_nbr3 = mode.cus_nbr + "%",
                    cus_nbr4 = mode.cus_nbr + "%",
                    cus_nbr5 = mode.cus_nbr + "%",
                    cus_nbr6 = mode.cus_nbr + "%"
                }).First();
            }
        }
        public bool GetRecords(string UID)
        {
            using (var conn = DapperConnection.GetSTOCK1Connection())
            {
                string _Sql = "SELECT COUNT(*) FROM userinfo WHERE userID = @userID AND password = @password";
                return conn.Query<int>(_Sql, new { userID = UID }).Single() > 0;
            }
        }
    }
}
