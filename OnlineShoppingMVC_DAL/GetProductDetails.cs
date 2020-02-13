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
    }
}
