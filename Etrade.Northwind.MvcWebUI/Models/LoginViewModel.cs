using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etrade.Northwind.MvcWebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }


    }
}
