using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepo;
        public CardService(ICardRepository cardRepo)
        {
            _cardRepo = cardRepo;
        }

        public List<Card> GetAll() => _cardRepo.GetAll();
        public Card GetById(int id) => _cardRepo.GetById(id);
        public void Insert(Card card) => _cardRepo.Insert(card);
        public void Update(Card card) => _cardRepo.Update(card);
        public void Delete(int id) => _cardRepo.Delete(id);

    }
}