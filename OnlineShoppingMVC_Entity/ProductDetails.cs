using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingMVC_Entity
{
    public class ProductDetails
    {
        public int productId
        {
            get;
            set;
        }
        public string productName
        {
            get;
            set;
        }
        public double productPrice
        {
            get;
            set;
        }
        public ProductDetails(int id, string name, double price)
        {
            this.productId = id;
            this.productName = name;
            this.productPrice = price;
        }
        public ProductDetails() { }
    }
}
