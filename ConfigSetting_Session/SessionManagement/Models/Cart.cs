using System;
using System.Collections.Generic;

namespace SessionManagement.Models{
    [Serializable] 
    public class Cart{
        public List<Item> Items=new List<Item>();
        public Cart(){ 
        }
    }
}