using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService        //kısayol aynı service ı başka isimle yaparken tekrar sınıf açmana gerek yok
    {                                                   //Database ın üzerine tıkla ampule tıkla move to namespace de kendisi otomatik sınıf açıp oraya atar 
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }
}
