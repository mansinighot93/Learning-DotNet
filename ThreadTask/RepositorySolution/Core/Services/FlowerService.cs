using Core.Models;
using Core.Repositories;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class FlowerService : IFlowerService 
    {
        private readonly IFlowerRepository _flowerRepo;

        public FlowerService(IFlowerRepository flowerRepo)
        {
            _flowerRepo = flowerRepo;
        }

        public List<Flower> GetAllSold() => _flowerRepo.GetAllSold();
    }
}
