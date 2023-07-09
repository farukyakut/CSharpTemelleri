// See https://aka.ms/new-console-template for more information
using OOP3;

Console.WriteLine("Hello, World!");

IhtiyacKrediManger ihtiyacKrediManger = new IhtiyacKrediManger();
ihtiyacKrediManger.Hesapla();

TasitKrediManager tasitKrediManager = new TasitKrediManager();
tasitKrediManager.Hesapla();

KonutKrediManager konutKrediManager = new KonutKrediManager();
konutKrediManager.Hesapla();

Console.WriteLine("-----------------------------------");

//Interfaceler'de class'lar gibi referans tutucudur(ama ınterface class tarafından implemente edilmelidir.)
IKrediManager ihtiyacKrediManger2 = new IhtiyacKrediManger();
ihtiyacKrediManger2.Hesapla();

IKrediManager tasitKrediManager2 = new TasitKrediManager();
tasitKrediManager2.Hesapla();

IKrediManager konutKrediManager2 = new KonutKrediManager();
konutKrediManager2.Hesapla();


Console.WriteLine("-----------------------------------");


IKrediManager ihtiyacKrediManger3 = new IhtiyacKrediManger();
IKrediManager tasitKrediManager3 = new TasitKrediManager();
IKrediManager konutKrediManager3 = new KonutKrediManager();

ILoggerService databaseLogerService = new DatabaseLogerService();
ILoggerService fileLoogerService = new FileLogerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManger3, databaseLogerService);
basvuruManager.BasvuruYap(tasitKrediManager3, databaseLogerService);
basvuruManager.BasvuruYap(konutKrediManager3, databaseLogerService);

Console.WriteLine("-----------------------------------");


IhtiyacKrediManger ihtiyacKrediManger4 = new IhtiyacKrediManger();
TasitKrediManager tasitKrediManager4 = new TasitKrediManager();
KonutKrediManager konutKrediManager4 = new KonutKrediManager();

BasvuruManager basvuruManager2 = new BasvuruManager();
basvuruManager2.BasvuruYap(ihtiyacKrediManger4,fileLoogerService);
basvuruManager2.BasvuruYap(tasitKrediManager4,fileLoogerService);
basvuruManager2.BasvuruYap(konutKrediManager4,fileLoogerService);

Console.WriteLine("------------------------");

List<IKrediManager> krediler = new List<IKrediManager>() 
{
    ihtiyacKrediManger3,
    tasitKrediManager3
};
basvuruManager.KrediOnBilgilendirmesiYap(krediler);




