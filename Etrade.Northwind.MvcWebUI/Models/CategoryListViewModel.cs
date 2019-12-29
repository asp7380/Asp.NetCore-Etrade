using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etrade.Northwind.Entities.Concrete;

namespace Etrade.Northwind.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; internal set; }
    }
}
