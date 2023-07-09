// See https://aka.ms/new-console-template for more information
using Dictionary;

Console.WriteLine("Hello, World!");


// Bir Dictionary örneği oluşturma.
Dictionary<string, int> dictionary = new Dictionary<string, int>();

// Dictionary'ye eleman ekleme.
dictionary.Add("kiraz", 50);
dictionary.Add("karpuz", 100);
dictionary.Add("mandalina", 75);

// Dictionary'deki tüm elemanların yazdırılması.
foreach (KeyValuePair<string, int> kvp in dictionary)
{
    Console.WriteLine("Anahtar = {0}, Değer = {1}", kvp.Key, kvp.Value);
}

// Dictionary'deki belirli bir elemanın değerini güncelleme.
dictionary["kiraz"] = 30;

// Dictionary'deki belirli bir elemanın değerini yazdırma.
int value;
if (dictionary.TryGetValue("kiraz", out value))
{
    Console.WriteLine("kiraz değeri: {0}", value);
}
else
{
    Console.WriteLine("kiraz anahtarı yok.");
}




//Kendi Dictionary yapımızı oluşturalım. 

MyDictionary<int, string> musteriBilgileri = new MyDictionary<int, string>();

musteriBilgileri.Add(13, "Ümit");
musteriBilgileri.Add(25, "Alba");
musteriBilgileri.Add(30, "Ferit");

// Kendi oluşturduğumuz KeyValuePair adlı yapıyı çalıştırıp yazdırma işlemi yapalım.

MyKeyValuePair<int, string> myKeyValuePair = new MyKeyValuePair<int, string>();

foreach (MyKeyValuePair<int, string> item in musteriBilgileri)
{
    Console.WriteLine("Numara: " + item.Key + ", İsim: " + item.Value);
}
