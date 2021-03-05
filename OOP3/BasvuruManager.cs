using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //basvuran bilgilerini değerlendirme
            krediManager.Hesapla(); //hangi krediManager gönderilmişse onun hesapla fonk.u çalışır.
            //loggerService.Log();//hangi loggerService gönderilmişse onu logla
            foreach (var loggerService in loggerServices)
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
