using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Etrade.Northwind.Entities.Concrete
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Lütfen geçerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Address { get; set; }
        [Required]
        [Range(15, 100, ErrorMessage = "Yaş değeri 15 ile 100 arası olmalıdır.")]
        public int Age { get; set; }
    }
}
