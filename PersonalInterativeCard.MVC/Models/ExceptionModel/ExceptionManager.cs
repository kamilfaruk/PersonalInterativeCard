using PersonalInterativeException.MVC.Models.ExceptionModel;
using Exception = PersonalInterativeCard.Data.Entities.Exception;
namespace PersonalInterativeCard.MVC.Models.ExceptionModel
{
    public class ExceptionManager
    {
        public IEnumerable<Exception> GetAll(IExceptionRepository exceptionRepository)
        {
            return exceptionRepository.GetAll();
        }
        public Exception Get(IExceptionRepository exceptionRepository, int exceptionId)
        {
            return exceptionRepository.Get(exceptionId);
        }
        public bool Delete(IExceptionRepository exceptionRepository, int exceptionId)
        {
            return exceptionRepository.Delete(exceptionId);

        }
        public bool Update(IExceptionRepository exceptionRepository, Data.Entities.Exception exception)
        {
            return exceptionRepository.Update(exception);
        }
        public bool Add(IExceptionRepository exceptionRepository, Data.Entities.Exception exception)
        {
            return exceptionRepository.Add(exception);
        }
    }
}
