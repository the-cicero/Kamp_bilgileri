string kategoriEtiketi = "kategoriler";
bool sistemeGirisYapmismi = true;
double dolarDun = 17.35;
double dolarBugun = 17.48;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azal�� butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Art�� butonu");
}
else
{
    Console.WriteLine("De�i�medi butonu");
}






if (sistemeGirisYapmismi == true)
{
    Console.WriteLine("Kullan�c� ayarlar� butonu");

}
else
{
    Console.WriteLine("Giri� yap butonu");
}
Console.WriteLine(kategoriEtiketi);