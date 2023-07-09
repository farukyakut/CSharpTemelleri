// See https://aka.ms/new-console-template for more information
using OOP2;

//base sınıf refreans tutucudur.


Console.WriteLine("Hello, World!");

GercekMusteri musteri1= new GercekMusteri();
musteri1.TcNo = "5555555";
musteri1.MusteriNo = "123";
musteri1.Id = 1;
musteri1.Adi = "Faruk";
musteri1.Soyadi = "YAKUT";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "45678";
musteri2.SirketAdi = "Faruke.com";
musteri2.VergiNo = "12344";

//Musteri(base class) hem GerçekMusteri hemde TuzelMusteri referansını tutabilir
Musteri musteri3 = new GercekMusteri();
musteri3.Id = 3;
musteri3.MusteriNo = "45678";

Musteri musteri4 = new TuzelMusteri();

CustomerManager customerManager1 = new CustomerManager();

customerManager1.Add(musteri1);
customerManager1.Add(musteri2);
customerManager1.Add(musteri3);
