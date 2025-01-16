using Core.Models;
using Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories
{
public class FruitRepository : IFruitRepository
{
    public List<Fruit> GetAllSold()
    {
        List<Fruit> Fruits = new List<Fruit>()
        {
            new Fruit()
            {
                ID = 1953772,
                Name = "Grapes",
                SalePrice = 8.99M,
                StoreCutPercentage = 0.75M,
                Quantity = 419
            },
            new Fruit()
            {
                ID = 2817721,
                Name = "Banana",
                SalePrice = 7.99M,
                StoreCutPercentage = 0.9M,
                Quantity = 112
            },
            new Fruit()
            {
                ID = 2177492,
                Name = "Watermelon",
                SalePrice = 8.49M,
                StoreCutPercentage = 0.67M,
                Quantity = 51
            },
            new Fruit()
            {
                ID = 2747119,
                Name = "Apple",
                SalePrice = 8.99M,
                StoreCutPercentage = 0.72M,
                Quantity = 214
            },
             new Fruit()
            {
                ID = 2747999,
                Name = "Pomegranate",
                SalePrice = 8.99M,
                StoreCutPercentage = 0.72M,
                Quantity = 214
            }
        };
        //DAL code
        //access using ORM entity framework

        return Fruits;
    }
}
}
