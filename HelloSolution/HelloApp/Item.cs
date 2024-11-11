using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Item
    {
        public Product theProduct {  get; set; } 
        public int Quantity { get; set; }
        public Item(Product product,int quantity) {
            theProduct = product;
            Quantity = quantity;
        }
    }
}
