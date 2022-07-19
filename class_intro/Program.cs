

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "Bağlama çalmaya başlıyorum";
kurs1.egitmen = "Mehmet Arif Akçadağ";
kurs1.izlenme_orani = 88;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Orta seviye bağlama kursu";
kurs2.egitmen = "Mehmet Arif Akçadağ";
kurs2.izlenme_orani = 78;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "İleri seviye bağlama kursu";
kurs3.egitmen = "Mehmet Arif Akçadağ";
kurs3.izlenme_orani = 68;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.egitmen + " : " + kurs.izlenme_orani);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string egitmen { get; set; }
    public int izlenme_orani { get; set; }

}