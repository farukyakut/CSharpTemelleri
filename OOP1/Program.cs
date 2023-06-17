// See https://aka.ms/new-console-template for more information
using OOP1;

Console.WriteLine("Hello, World!");

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitePrice = 10;
product1.UnitsInStock = 3;

Product product2 = new Product()
{
    UnitsInStock = 3,
    CategoryId = 2,
    UnitePrice = 10,
    ProductName = "kalem",
    Id = 1
};
//PascalCase   //camelCase 
// değişken class olduğu için(product1) refereans tip
ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);

//değişken int olduğu için değer tip
int sayi = 100;
productManager.BirseyYap(sayi);
Console.WriteLine(sayi);

productManager.Topla2(2,3);

int kullanılacakDeğer = productManager.Topla(2,3);

Console.WriteLine(kullanılacakDeğer*2);