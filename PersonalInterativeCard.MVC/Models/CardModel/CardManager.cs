using PersonalInterativeCard.Data.Entities;

namespace PersonalInterativeCard.MVC.Models.CardModel
{
    public class CardManager
    {
        public IEnumerable<Card> GetAll(ICardRepository cardRepository)
        {
            return cardRepository.GetAll();
        }
        public Card Get(ICardRepository cardRepository, int cardId)
        {
            return cardRepository.Get(cardId);
        }
        public bool Delete(ICardRepository cardRepository, int cardId)
        {
            return cardRepository.Delete(cardId);

        }
        public bool Update(ICardRepository cardRepository, Card card)
        {
            return cardRepository.Update(card);
        }
        public bool Add(ICardRepository cardRepository, Card card)
        {
            return cardRepository.Add(card);
        }
    }
}
