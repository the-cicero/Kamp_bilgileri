
string kurs1 = "Bağlama çalmaya başlıyorum";
string kurs2 = "Orta seviye bağlama kursu";
string kurs3 = "İleri seviye bağlama kursu";

string[] kurslar = new string[] { "Bağlama çalmaya başlıyorum",
"Orta seviye bağlama kursu", "İleri seviye bağlama kursu"};



for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for sonu\n");


foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu - footer");