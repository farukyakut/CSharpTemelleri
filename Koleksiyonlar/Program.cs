// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Diziler
string[] isimler = new string[] 
{ 
    "Engin",
    "Faruk",
    "hasan",
    "Veli"
};
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);

//rage dışı patlar
//Console.WriteLine(isimler[4]);
//listelere eklenme yapılamaz bu sorun koleksiyonlarla çözülür
//isimler[4] = "İlker";
//Console.WriteLine(isimler[4]);

isimler = new string[5];
isimler[4] = "ilker";
Console.WriteLine(isimler[4]);
Console.WriteLine(isimler[0]);

//----------------------------------------------------------
//Koleksiyon

List<string> isimler2 = new List<string>
{

    "Engin",
    "Faruk",
    "hasan",
    "Veli"
};

Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("İlker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);

