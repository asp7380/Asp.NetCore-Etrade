using Etrade.Core.DataAccess.EntityFramework;
using Etrade.Northwind.DataAccess.Abstract;
using Etrade.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Etrade.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
