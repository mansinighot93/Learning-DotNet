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

        }

        public Product(int id, string title, string description, double unitPrice, int quantity, string imageUrl)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.ImageUrl = imageUrl;
        }
        ~Product()
        {

        }
        public override string ToString()
        {
            return this.Id + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity + " " + this.ImageUrl;
        }
    }
}
