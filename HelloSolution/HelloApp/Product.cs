using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Product
    {
        public string title;
        public string description;
        public double unitPrice;
        public int qunatity;
        public int id;

        //Read only Property
        public int ID
        {
            set { this.id = value; }
            get { return this.id;}
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice;}
            set { this.unitPrice = value;}
        }
        public int Qunatity
        {
            get { return this.qunatity; }
            set { this.qunatity = value;}
        }

        public Product() { 

        }
        public Product(int id,string title, string description, double unitPrice,int quantity)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.unitPrice = unitPrice;  
            this.qunatity= quantity;
        }
        ~Product() { 
        
        }
        public override string ToString() { 
            return this.id + " " + this.title + " " + this.description + " " + this.unitPrice + " " + this.qunatity;
        }
    }
}
