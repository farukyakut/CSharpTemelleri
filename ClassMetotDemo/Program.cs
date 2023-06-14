// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Console.WriteLine("Hello, World!");
// Banka Müşteri takip

Musteri musteri = new Musteri()
{
    Name = "Ahmet",
    Surname = "Beyoğlu",
    Tc = 58962695786
};

Musteri musteri2 = new Musteri()
{
    Name = "Mehmet",
    Surname = "Beyoğlu",
    Tc = 58962695787
};

MusteriManager musteriManager = new MusteriManager();

musteriManager.Güncelleme(musteri);
musteriManager.Silme(musteri);
musteriManager.Add(musteri);


