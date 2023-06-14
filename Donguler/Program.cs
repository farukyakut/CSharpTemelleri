// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int length = 10;

for (int i = 0; i < length; i++)
{
    Console.WriteLine(i);

}
Console.WriteLine("------------------------------------------");

for (int i = 0; i < length; i+=2)
{
    Console.WriteLine(i);

}

string[] kurslar = new string[]
{
    "Python Programla Kursu",
    "C# Programlama Kursu",
    "Programlaya Giriş"
};

Console.WriteLine("------------------------------------------");

for (int i = 0; i < kurslar.Length; i ++)
{
    Console.WriteLine(kurslar[i]);
}


Console.WriteLine("------------------------------------------");
//listeleri dolaşmak için kullanılır
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


