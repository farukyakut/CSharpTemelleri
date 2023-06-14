// See https://aka.ms/new-console-template for more information
using Gun3Odev2;

Console.WriteLine("Hello, World!");

//ref ve out örnekleri yapınız

//ref keyword 'ü main'de çalıştırdıgımız bir metodun değerlerinin main içerisinden atanan parametrelerin referans edilmesiyle kullanılır. 
// Out keyword'ü ref keyword'ü ile aynı işi yapar. Out' keyword'ü main'de atanan bir parametrenin degeri null olması durumda çalışmaz, ref keyword'ünden 
// ayrılan temel farkı budur.


int number1 = 20;
int number2 = 30;


Add add = new Add();
add.Add1(number1, number2);
Console.WriteLine(number1);
Console.WriteLine("--------------------");
add.Add2(ref number1, number2);
Console.WriteLine(number1);
Console.WriteLine("--------------------");
add.Add3(out number1, number2);
Console.WriteLine(number1);


