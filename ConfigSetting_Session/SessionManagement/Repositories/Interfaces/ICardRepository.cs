using Core.Models;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface ICardRepository
    {
        public List<Card> GetAll();
        public Card GetById(int id);
        public void Insert(Card card);
        public void Update(Card card);
        public void Delete(int id);
    }
}
