using PersonalInterativeCard.Data.Entities;
namespace PersonalInterativeCard.MVC.Models.CardModel
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetAll();
        Card Get(int cardId);
        bool Add(Card card);
        bool Delete(int cardId);
        bool Update(Card card);
    }
}
