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
            IEnumerable<ProductList> product = getProduct.ReturnProductDetails();
            return View(product);
        }
        public ActionResult TempDataProduct()
        {
            IEnumerable<ProductList> product = getProduct.ReturnProductDetails();
            TempData["Product"] = product;
            return RedirectToAction("TempDataProductRedirect");
        }
        public ActionResult TempDataProductRedirect()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ProductList ProductList)
        {
            getProduct.AddProduct(ProductList);
            TempData["Message"] = "Product added Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ProductList product = getProduct.GetProduct(id);
            return View(product);
        }
        public ActionResult Delete(int id)
        {
            getProduct.DeleteProduct(id);
            TempData["Message"] = "Package deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(ProductList ProductList)
        {
            getProduct.UpdatePackage(ProductList);
            TempData["Message"] = "Package updated";
            return RedirectToAction("Index");
        }
    }
}