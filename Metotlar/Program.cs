﻿using System;

namespace Metotlar
{

    class Program
    {

        static void Main(String[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama + "\n");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^\n");

            }

            Console.WriteLine("***********Metotlar************\n");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,9);
            sepetManager.Ekle2("Elma", "Sarı elma", 18, 14);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 13,23 );
        }
     }
}
