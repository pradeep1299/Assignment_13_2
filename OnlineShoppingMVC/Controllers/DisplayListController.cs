using OnlineShoppingMVC_DAL;
using OnlineShoppingMVC_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingMVC.Controllers
{
    public class DisplayListController : Controller
    {
        GetProductDetails getProduct;

        public DisplayListController()
        {
            getProduct = new GetProductDetails();
        }

        // GET: DisplayList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewDataProduct()
        {
            IEnumerable<ProductList> product = getProduct.ReturnProductDetails();
            ViewData["Product"] = product;
            return View();
        }

        public ActionResult ViewBagProduct()
        {
            IEnumerable<ProductList> product = getProduct.ReturnProductDetails();
            ViewBag.Product = product;
            return View();
        }

        public ActionResult TempDataProduct()
        {
            IEnumerable<ProductList> product = getProduct.ReturnProductDetails();
            TempData["Product"] = product;
            return View();
        }
    }
}