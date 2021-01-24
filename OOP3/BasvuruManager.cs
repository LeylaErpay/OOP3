using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //List<ILoggerService> loggerServices çoğuldur , ILoggerService loggerService tekildir
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)
        {
            //basvuruan bilgilerini değerlendirme
            //  KonutKrediManager konutKrediManager = new KonutKrediManager(); // eğer böyle yazarsan tüm kredileri konut olarak hesaplar
            krediManager.Hesapla();    //böyle yazarsan istediğin krediye göre hesaplatabilirisn
            //loggerService.Log();      //böyle yazarsan tekil olur
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
