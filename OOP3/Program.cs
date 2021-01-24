using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //yukarıdakini aşağıdaki gibi de yazabiliriz
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            // tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


          //  ILoggerService databaseLoggerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            //   basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService()); //20.satırı böylede yazabiliriz

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List <ILoggerService> { new DatabaseLoggerService(), new FilebaseLoggerService(), new SmsLoggerService() });

            //List<IKrediManager> krediler = new List<IKrediManager>() { IhtiyacKrediManager };

          //  basvuruManager.KrediOnBilgilendirmeYap(krediler);
          
        }
    }
}
