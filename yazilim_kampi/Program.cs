string kategoriEtiketi = "kategoriler";
bool sistemeGirisYapmismi = true;
double dolarDun = 17.35;
double dolarBugun = 17.48;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalýþ butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artýþ butonu");
}
else
{
    Console.WriteLine("Deðiþmedi butonu");
}






if (sistemeGirisYapmismi == true)
{
    Console.WriteLine("Kullanýcý ayarlarý butonu");

}
else
{
    Console.WriteLine("Giriþ yap butonu");
}
Console.WriteLine(kategoriEtiketi);