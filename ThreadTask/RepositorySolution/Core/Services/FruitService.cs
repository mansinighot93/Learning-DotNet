using Core.Models;
using Core.Repositories;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class FruitService : IFruitService
    {
        private readonly IFruitRepository _FruitRepo;

        public FruitService(IFruitRepository FruitRepo)
        {
            _FruitRepo = FruitRepo;
        }

        public List<Fruit> GetAllSold() => _FruitRepo.GetAllSold();
    }
}
