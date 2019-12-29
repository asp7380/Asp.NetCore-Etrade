using Etrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Etrade.Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        [Required(ErrorMessage ="Bu alanın doldurulması zorunludur.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public decimal UnitPrice { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur.")]
        public short UnitsInStock { get; set; }
    }
}
