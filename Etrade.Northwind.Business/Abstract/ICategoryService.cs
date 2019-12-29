using Etrade.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etrade.Northwind.Business.Concrete
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
