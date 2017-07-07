using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfoModel
    {
        /// <summary>
        /// 用戶編號
        /// </summary>
        public string userID { get; set; }
        /// <summary>
        /// 用戶名稱
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 用戶密碼
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 用戶密碼
        /// </summary>
        public DateTime? OnDate { get; set; }
    }
}
