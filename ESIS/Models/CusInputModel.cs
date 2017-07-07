using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESIS.Models
{
    public class CusInputModel
    {
        /// <summary>
        /// 查詢
        /// </summary>
        [Required]
        [Display(Name = "查詢")]
        public string CusKey { get; set; }
    }
}