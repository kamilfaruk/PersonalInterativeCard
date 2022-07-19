using Exception = PersonalInterativeCard.Data.Entities.Exception;

namespace PersonalInterativeException.MVC.Models.ExceptionModel
{
    public interface IExceptionRepository
    {
        IEnumerable<Exception> GetAll();
        Exception Get(int exceptionId);
        bool Add(Exception exception);
        bool Delete(int exceptionId);
        bool Update(Exception exception);
    }
}
