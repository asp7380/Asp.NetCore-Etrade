using Etrade.Core.DataAccess.EntityFramework;
using Etrade.Northwind.DataAccess.Abstract;
using Etrade.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Etrade.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
       
    }
}
