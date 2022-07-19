namespace PersonalInterativeCard.MVC.Exceptions
{
    public class LogException : Exception
    {
        string message;
        public LogException(string msg) : base(msg)
        {
            message = msg;
        }
        public LogException(string msg, Exception innerEx) : base(msg, innerEx)
        {
            string message = ParseException();
        }
        public string ParseException()
        {
            if (this.InnerException is OutOfMemoryException)
            {
                return "Programın çalışması için yeterli bellek kalmadı.";
            }
            else if (this.InnerException is StackOverflowException)
            {
                return "Stack(Yığın) bellek bölgesinin birden fazla metod için kullanılıyor. (Kendini çağıran metodların hatalı kullanılmadığını kontrol ediniz.";
            }
            else if (this.InnerException is NullReferenceException)
            {
                return "Bellekte yer ayrılmamış bir nesne üzerinden sınıfın üye elemanlarına erişmeye çalışıldı.";
            }
            else if (this.InnerException is OverflowException)
            {
                return "Bir veri türüne kapasitesinden fazla veri yüklemeye çalışıldı";
            }
            else if (this.InnerException is InvalidCastException)
            {
                return "Tür dönüştürme operatörüyle geçersiz tür dönüşümü yapılmaya çalışıldı.";
            }
            else if (this.InnerException is IndexOutOfRangeException)
            {
                return "Bir dizinin olmayan elemanına erişilmeye çalışıldı";
            }
            else if (this.InnerException is ArrayTypeMismatchException)
            {
                return "Bir dizinin elemanına yanlış türde veri atanmaya çalışıldı.";
            }
            else if (this.InnerException is DivideByZeroException)
            {
                return "Herhangi bir sayı sıfıra bölünmeye çalışıldı.";
            }
            else if (this.InnerException is ArithmeticException)
            {
                return "Matematiksel bir hesaplama hatası yapıldı";
            }
            else if (this.InnerException is FormatException)
            {
                return "Metodlara yanlış biçimde parametre verildi.";
            }
            else
            {
                return this.InnerException.Message.ToString();
            }
        }
    }
}
