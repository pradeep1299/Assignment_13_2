using System;
using OnlineShoppingMVC_Entity;
using System.Collections.Generic;

namespace OnlineShoppingMVC_DAL
{
    public class GetProductDetails
    {
        public static List<ProductList> product = new List<ProductList>();

        static GetProductDetails()
        {
            product.Add(new ProductList(21,"Cycle",4500.25));
            product.Add(new ProductList(45, "Cookies", 54.00));
            product.Add(new ProductList(87, "Headset", 540));
        }
        public IEnumerable<ProductList> ReturnProductDetails()
        {
            return product;
        }
        public void AddProduct(ProductList ProductList)
        {
            product.Add(ProductList);
        }
        public ProductList GetProduct(int productId)
        {
            return product.Find(id => id.productId == productId);
        }
        public void DeleteProduct(int productId)
        {
            ProductList list = GetProduct(productId);
            if (list != null)
                product.Remove(list);
        }
        public void UpdatePackage(ProductList ProductList)
        {
            ProductList packages = GetProduct(ProductList.productId);
            packages.productName = ProductList.productName;
            packages.productPrice = ProductList.productPrice;
        }
    }
}
