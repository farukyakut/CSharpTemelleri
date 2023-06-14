// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//type safety = (tip güvenliği)
//do not yourself - kendini tekrarlama
//değer tutucu alias
string kategoriEtiketi = "kategoriler";
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.36;
double dolarBugun = 7.48;

if(dolarDun > dolarBugun)
{
    Console.WriteLine("Düşüş butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}


Console.WriteLine(kategoriEtiketi);

if(sistemeGirisYapmisMi != false)
{
    Console.WriteLine("Kullanıcı bilgilerini getir");
}
else
{
    Console.WriteLine("Giriş Yap butonu");
}