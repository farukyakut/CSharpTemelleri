// See https://aka.ms/new-console-template for more information
using GenericIntro;

Console.WriteLine("Hello, World!");

//Generic ile kendi koleksiyonumuzu oluşturma

MyList<string> isimler = new MyList<string>();
isimler.Add("Faruk");

Console.WriteLine(isimler.Length);

isimler.Add("Mahme");
Console.WriteLine(isimler.Length);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}
