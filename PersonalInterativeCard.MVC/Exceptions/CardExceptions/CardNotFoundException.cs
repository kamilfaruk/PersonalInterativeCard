namespace PersonalInterativeCard.MVC.Exceptions.CardExceptions
{
    public class CardNotFoundException : LogException
    {
        public CardNotFoundException() : base("Girilen kart bilgileri sistemde bulunamadı.") { }
    }
}
