
using System.Collections.Generic;
using ProductsWebAPI.Models;

namespace ProductsWebAPI.Repositories
{
    public interface IProductManager{
        List<Product> GetAll();
        Product GetById(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}