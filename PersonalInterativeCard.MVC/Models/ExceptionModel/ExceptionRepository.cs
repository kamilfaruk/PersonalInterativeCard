using PersonalInterativeCard.Data;
using Exception = PersonalInterativeCard.Data.Entities.Exception;

namespace PersonalInterativeException.MVC.Models.ExceptionModel
{
    public class ExceptionRepository : IExceptionRepository
    {

        private readonly InteractiveCardDbContext interactiveCardDbContext;

        public ExceptionRepository(InteractiveCardDbContext _context)
        {
            interactiveCardDbContext = _context;
        }

        public bool Add(Exception exception)
        {
            interactiveCardDbContext.Exception.Add(exception);
            return interactiveCardDbContext.SaveChanges() > 0;
        }

        public bool Delete(int exceptionId)
        {
            Exception exception = Get(exceptionId);
            interactiveCardDbContext.Exception.Remove(exception);
            return interactiveCardDbContext.SaveChanges() > 0;

        }

        public Exception Get(int exceptionId)
        {
            return interactiveCardDbContext.Exception.Where(_exception => _exception.Id == exceptionId).FirstOrDefault();
        }

        public IEnumerable<Exception> GetAll()
        {
            return interactiveCardDbContext.Exception.ToList();
        }

        public bool Update(Exception exception)
        {
            interactiveCardDbContext.Update(exception);
            return interactiveCardDbContext.SaveChanges() > 0;
        }
    }
}
