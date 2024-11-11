using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        private List<Item> items = new List<Item>();
        public List<Item> Items{
            get{ return items; }
            set{ items = value; }
        }
        public void AddToCart(Item item){
            items.Add(item);
        }
        public void RemoveFromCart(Item item){
            items.Remove(item); 
        }
    }
}
