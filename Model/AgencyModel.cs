using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AgencyModel
    {
        /// <summary>
        /// 機構代號
        /// </summary>
        public string AgencyCode { get; set; }
        /// <summary>
        /// 機構名稱
        /// </summary>
        public string AgencyName { get; set; }
        /// <summary>
        /// 機構地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 機構電話
        /// </summary>
        public string TEL { get; set; }
    }
}
