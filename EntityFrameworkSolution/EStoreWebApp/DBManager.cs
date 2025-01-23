using System.Collections.Generic;
namespace EStoreWebApp
{
    public class DBManager : IDBManager
    {
        public List<Product> GetAll()
        {
            using(var context = new CollectionContext())
            {
                var products = from prod in context.Products select prod;
                return products.ToList<Product>();
            }
        }

        public Product GetById(int id)
        {
            using(var context = new CollectionContext())
            {
                var product = context.Products.Find(id);
                return product;
            }
        }

        public void Insert(Product product)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using(var context = new CollectionContext())
            {
                var theProduct = context.Products.Find(product.Id);
                theProduct.Title = product.Title;
                theProduct.Quantity = product.Quantity;
                theProduct.UnitPrice = product.UnitPrice;
                theProduct.Description = product.Description;
                //context.Products.Update(product);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
        }
    }
}