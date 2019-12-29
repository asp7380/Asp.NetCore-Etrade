using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etrade.Northwind.MvcWebUI.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        //[DataType(DataType.Password)]
        //public string ConfirmedPassword { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Lütfen geçerli bir mail adresi girin")]
        public string Email { get; set; }


    }
}
