using Etrade.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etrade.Northwind.MvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {

            UserDetailsViewModel model = new UserDetailsViewModel
            {
                UserName = HttpContext.User.Identity.Name
            };

            return View(model);
        }


    }
}
