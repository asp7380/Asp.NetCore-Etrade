using System;
using System.Collections.Generic;
using System.Text;
using Etrade.Northwind.DataAccess.Abstract;
using Etrade.Northwind.DataAccess.Concrete.EntityFramework;
using Etrade.Northwind.Entities.Concrete;

namespace Etrade.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _ProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }
        public void Add(Product product)
        {
            _ProductDal.Add(product);
        }

        public void Delete(int productId)
        {
             _ProductDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetAll()
        {
            return _ProductDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _ProductDal.GetList(p => p.CategoryId == categoryId||categoryId==0);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p => p.ProductId == productId);
        }

        public void Update(Product product)
        {
            _ProductDal.Update(product);
        }
    }
}
