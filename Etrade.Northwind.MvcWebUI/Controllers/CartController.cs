using Etrade.Northwind.Business.Abstract;
using Etrade.Northwind.Business.Concrete;
using Etrade.Northwind.Entities.Concrete;
using Etrade.Northwind.MvcWebUI.Models;
using Etrade.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etrade.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToBeAdded);

            _cartSessionService.SetCard(cart);

            TempData.Add("message", String.Format("Ürün eklendi!"));

            return RedirectToAction("Index","Product");

        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };

            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCard(cart);

            TempData.Add("message", String.Format("Ürün silindi!"));

            return RedirectToAction("List");
        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };

            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Alışveriş tamamlandı"));

            return View();
           
        }

    }
}
