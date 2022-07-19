using Microsoft.AspNetCore.Mvc;
using PersonalInterativeCard.MVC.Models;
using PersonalInterativeCard.MVC.Models.CardModel;
using System.Diagnostics;
using NLog;

namespace PersonalInterativeCard.MVC.Controllers
{
    public class HomeController : Controller
    {
        //private Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly ICardRepository _cardRepository;

        public HomeController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public IActionResult Index()
        {
            Data.Entities.Card card = new Data.Entities.Card();
            card.Name = "Şükran";
            card.Surname = "Yel";
            card.FacebookLink = "Face test";
            card.InstagramLink = "Insta test";
            card.MailAddress = "kamilfarukyel94@gmail.com";
            card.Mail = "kamilfarukyel94@gmail.com";
            card.CreatedTime = DateTime.Now;
            card.UpdatedTime = DateTime.Now;
            card.ViewLink = "deneme link";
            card.Phone = "05352005777";
            card.IsActive = true;
            //_cardRepository.Add(card);
            try
            {
                int i = 153;
                int j = 0;
                int k = i / j;
            }
            catch (Exception _ex)
            {
                Exceptions.LogException exception = new Exceptions.LogException("Bu bir hatadır", _ex);
                //_logger.Error(exception);
            }

            return View();

        }

        public IActionResult Privacy()
        {
            List<Data.Entities.Card> _cardList = _cardRepository.GetAll().ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}