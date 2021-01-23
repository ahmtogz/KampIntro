using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManger = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            //new lemeye iki örnek yukarida var. parantez icerinde new verip gecebiliriz


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManger, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
