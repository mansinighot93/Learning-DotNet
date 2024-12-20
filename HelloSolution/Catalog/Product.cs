using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{

    [Serializable]
    public class Product
    {
        public int Likes { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            this.Id = 2;
            this.Title = "Honda City";
            this.Description = "Best Automobile";
            this.Quantity = 1000;
            this.UnitPrice = 1000000;
        }

        public Product(int id, string title, string description, double unitPrice, int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
        ~Product()
        {

        }
        public override string ToString()
        {
            return this.Id + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }
    }
}
