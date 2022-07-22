using System;
using System.Collections.Generic;

namespace OOP_3
{

    class Program
    {


        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyackrediManager = new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new esnafKredisiManager(), new smsLoggerService());

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyackrediManager, tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler); 
        }

    }


}