using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESIS.Models
{
    public class UserBasicInputModel
    {
        /// <summary>
        /// 用戶編號
        /// </summary>
        [Required]
        [Display(Name = "員工代號")]
        public string Account { get; set; }
        /// <summary>
        /// 用戶密碼
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }
    }
}