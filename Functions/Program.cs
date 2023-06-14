// See https://aka.ms/new-console-template for more information
using Functions;



Urun urun1 = new Urun();
urun1.Aciklama = "Amasya elması";
urun1.Adi = "Elma";
urun1.Fiyati = 15;

Urun urun2 = new Urun();
urun2.Aciklama = "Karpuz gibi karpuz";
urun2.Adi = "Karpuz";
urun2.Fiyati = 60;

Urun[] urunler = new Urun[]
{
    urun1,
    urun2
};

//Type-safe -- Tip güvenli
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi + " " + urun.Aciklama +" "+ urun.Fiyati);
    Console.WriteLine("----------------------------");
}

Console.WriteLine("--------------Metotlar--------------");

//instance - örnek

//encapsulation  == ayrı ayrı yapacağın işi daha planlı ve az iş gücüyle yapmak
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


// bu yöntem yanlış çünkü yeni ekleme yapılınca(stok sonradan eklendi) tüm fonksiyonlara tek tek eklemek gerekir
sepetManager.Ekle2("Vişne", "Vişne Vine suyu", 35, 10);
sepetManager.Ekle2("Muz", "Amazon muzz", 35, 10);
sepetManager.Ekle2("Şeftali", "Neftali gibi şeftali", 35, 10);

