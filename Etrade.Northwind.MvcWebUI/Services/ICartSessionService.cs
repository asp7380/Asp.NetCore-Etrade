using Etrade.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etrade.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();

        void SetCard(Cart cart);



    }
}
