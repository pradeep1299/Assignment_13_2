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
        ProductRepostary getProduct;

        public DisplayListController()
        {
            getProduct = new ProductRepostary();
        }

        // GET: DisplayList
        public ActionResult Index()
        {
            IEnumerable<ProductDetails> product = getProduct.ReturnProductDetails();
            return View(product);
        }
        public ActionResult TempDataProduct()
        {
            IEnumerable<ProductDetails> product = getProduct.ReturnProductDetails();
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
        [ActionName("Add")]
        public ActionResult AddProduct(FormCollection Form)
        {
            int id = Convert.ToInt32(Request.Form["productId"]);
            string name = Request.Form["productName"];
            double price = Convert.ToDouble(Request.Form["productPrice"]);
            ProductDetails ProductList = new ProductDetails(id, name, price);
            TryUpdateModel(ProductList);
            getProduct.AddProduct(ProductList);
            TempData["Message"] = "Product added Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ProductDetails product = getProduct.GetProduct(id);
            return View(product);
        }
        public ActionResult Delete(int id)
        {
            getProduct.DeleteProduct(id);
            TempData["Message"] = "Package deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update()
        {
            ProductDetails ProductList = new ProductDetails();
            UpdateModel(ProductList);
            getProduct.UpdatePackage(ProductList);
            TempData["Message"] = "Package updated";
            return RedirectToAction("Index");
        }
    }
}