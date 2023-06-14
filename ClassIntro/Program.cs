// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.IzlenmeIranı = 300;
kurs1.Egitmen = "Faruk YAKUT";
kurs1.KursAdı = "C#";

Console.WriteLine(kurs1.Egitmen + " : " + kurs1.KursAdı);

Console.WriteLine("-----------------------");

Kurs kurs2 = new Kurs()
{
  IzlenmeIranı = 400,
  Egitmen = "Ali YAKUT",
  KursAdı = "PHP"
};




Kurs kurs3 = new Kurs();
kurs3.IzlenmeIranı = 300;
kurs3.Egitmen = "Emin YAKUT";
kurs3.KursAdı = "Python";

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.Egitmen +" : " + kurs.KursAdı);
}

class Kurs
{
    public string KursAdı { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeIranı { get; set; }

}