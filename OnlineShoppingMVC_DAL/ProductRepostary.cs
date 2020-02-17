using System;
using OnlineShoppingMVC_Entity;
using System.Collections.Generic;

namespace OnlineShoppingMVC_DAL
{
    public class ProductRepostary
    {
        public static List<ProductDetails> product = new List<ProductDetails>();

        static ProductRepostary()
        {
            product.Add(new ProductDetails(21,"Cycle",4500.25));
            product.Add(new ProductDetails(45, "Cookies", 54.00));
            product.Add(new ProductDetails(87, "Headset", 540));
        }
        public IEnumerable<ProductDetails> ReturnProductDetails()
        {
            return product;
        }
        public void AddProduct(ProductDetails ProductList)
        {
            product.Add(ProductList);
        }
        public ProductDetails GetProduct(int productId)
        {
            return product.Find(id => id.productId == productId);
        }
        public void DeleteProduct(int productId)
        {
            ProductDetails list = GetProduct(productId);
            if (list != null)
                product.Remove(list);
        }
        public void UpdatePackage(ProductDetails ProductList)
        {
            ProductDetails packages = GetProduct(ProductList.productId);
            packages.productName = ProductList.productName;
            packages.productPrice = ProductList.productPrice;
        }
    }
}
