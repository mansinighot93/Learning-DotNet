using System;
using System.Collections.Generic;
using ProductsWebAPI.Models;

namespace ProductsWebAPI.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}