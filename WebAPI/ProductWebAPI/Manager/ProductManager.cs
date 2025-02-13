using Core.Context;
using ProductsWebAPI.Models;


namespace ProductWebApi.Manager
{
    public class ProductManager : IProductManager
    {
        public bool Delete(int id)
        {
            bool status=false;
           using(var context=new CollectionContext())
           {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
            status=true;
           }
           return status;
        }

        public Product GetProductById(int id)
        {
            using(var context=new CollectionContext())
            {
                Product p=context.Products.Find(id);
                return p;
            }
        }

        public List<Product> GetProducts()
        {
            using(var context=new CollectionContext())
            {
                var product =from p in context.Products select p;
                return product.ToList<Product>();

            }
        }

        public bool Insert(Product product)
        {
            bool status=false;
            using(var context=new CollectionContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                status=true;
            }
            return status;
        }

        public bool Update(Product product)
        {
            bool status = false;
            using (var context = new CollectionContext())
            {
                var p=context.Products.Find(product.Id);
                p.Title=product.Title;
                p.UnitPrice=product.UnitPrice;
                p.Description=product.Description;
                p.Quantity=product.Quantity;
                context.SaveChanges();
                status=true;
            }
            return status;
        }
    }
}