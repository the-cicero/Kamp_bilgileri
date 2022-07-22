using System;
using System.Collections.Generic;

namespace OOP_2
{

    class Program
    {


        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet Arif";
            musteri1.SoyAdi = "Akçadağ";
            musteri1.TcNo = "11111111111";
            


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "23456";
            musteri2.SirketAdi = "Karaambar kamyoncular derneği";
            musteri2.VergiNo = "123456789";


            // new bellekteki referans numarası


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);



        }

    }


}