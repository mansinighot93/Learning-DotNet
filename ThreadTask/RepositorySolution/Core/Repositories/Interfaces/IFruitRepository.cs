using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories.Interfaces
{
    public interface IFruitRepository
    {
        List<Fruit> GetAllSold();
    }
}
