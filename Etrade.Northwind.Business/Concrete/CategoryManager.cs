using System;
using System.Collections.Generic;
using System.Text;
using Etrade.Northwind.DataAccess.Abstract;
using Etrade.Northwind.Entities.Concrete;

namespace Etrade.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
