using Etrade.Core.DataAccess;
using Etrade.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Etrade.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
