using PersonalInterativeCard.Data;
using PersonalInterativeCard.Data.Entities;

namespace PersonalInterativeCard.MVC.Models.CardModel
{
    public class CardRepository : ICardRepository
    {

        private readonly InteractiveCardDbContext interactiveCardDbContext;

        public CardRepository(InteractiveCardDbContext _context)
        {
            interactiveCardDbContext = _context;
        }

        public bool Add(Card card)
        {
            interactiveCardDbContext.Card.Add(card);
            return interactiveCardDbContext.SaveChanges() > 0;
        }

        public bool Delete(int cardId)
        {
            Card card = Get(cardId);
            interactiveCardDbContext.Card.Remove(card);
            return interactiveCardDbContext.SaveChanges() > 0;

        }

        public Card Get(int cardId)
        {
            return interactiveCardDbContext.Card.Where(_card => _card.Id == cardId).FirstOrDefault();
        }

        public IEnumerable<Card> GetAll()
        {
            return interactiveCardDbContext.Card.ToList();
        }

        public bool Update(Card card)
        {
            interactiveCardDbContext.Update(card);
            return interactiveCardDbContext.SaveChanges() > 0;
        }

    }
}
