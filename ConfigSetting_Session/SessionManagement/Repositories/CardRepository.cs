using Core.Models;
using Core.Repositories.Interfaces;
using SessionManagement.Models;
using System.Collections.Generic;

namespace Core.Repositories
{
    public class CardRepository : ICardRepository
    {
        public List<Card> GetAll()
        {
            using (var context = new RepoCollectionContext())
            {
                var card = from prod in context.Cards select prod;
                return card.ToList<Card>();
            }
        }

        public Card GetById(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                var card = context.Cards.Find(id);
                return card;
            }
        }

        public void Insert(Card card)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Cards.Add(card);
                context.SaveChanges();
            }
        }

        public void Update(Card card)
        {
            using (var context = new RepoCollectionContext())
            {
                var theCard = context.Cards.Find(card.Id);
                theCard.CardType = card.CardType;
                theCard.CardNumber = card.CardNumber;
                theCard.AccountId = card.AccountId;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new RepoCollectionContext())
            {
                context.Cards.Remove(context.Cards.Find(id));
                context.SaveChanges();
            }
        }
    }
}

