using System.Collections.Generic;
using Etrade.Northwind.Entities.Concrete;

namespace Etrade.Northwind.MvcWebUI
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}