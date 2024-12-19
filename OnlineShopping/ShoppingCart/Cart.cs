using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public class Cart 
    {
        public List<Item> Items { get; private set; }
        public static readonly Cart Instance;
    
        protected Cart() { }
    
        
        public void AddItem(int productId) {
            Item newItem = new Item(productId);
            // If this item already exists in our list of items, increase the quantity
            // Otherwise, add the new item to the list
            if (Items.Contains(newItem)) {
                foreach (Item item in Items) {
                    if (item.Equals(newItem)) {
                        item.Quantity++;
                        return;
                    }
                }
            } else {
                newItem.Quantity = 1;
                Items.Add(newItem);
            }
        }
    
        /**
        * SetItemQuantity() - Changes the quantity of an item in the cart
        */
        public void SetItemQuantity(int productId, int quantity) {
            // If we are setting the quantity to 0, remove the item entirely
            if (quantity == 0) {
                RemoveItem(productId);
                return;
            }
    
            // Find the item and update the quantity
            Item updatedItem = new Item(productId);
    
            foreach (Item item in Items) {
                if (item.Equals(updatedItem)) {
                    item.Quantity = quantity;
                    return;
                }
            }
        }
    
        /**
        * RemoveItem() - Removes an item from the shopping cart
        */
        public void RemoveItem(int productId) {
            Item removedItem = new Item(productId);
            Items.Remove(removedItem);
        }
    
        /**
        * GetSubTotal() - returns the total price of all of the items
        *                 before tax, shipping, etc.
        */
        public double GetSubTotal() {
            double subTotal = 0;
            foreach (Item item in Items)
                subTotal += item.TotalPrice;
    
            return subTotal;
        }
    }
}
