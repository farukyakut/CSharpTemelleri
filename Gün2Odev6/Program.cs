// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Product product1 = new Product()
{
    ProductName = "Ayakkabı",
    Category = "Erkek",
    ProductBrand = "Adıdas",
    ProductPrice = 1650.50f
};

Product product2 = new Product()
{
    ProductName = "kazak",
    Category = "Erkek",
    ProductBrand = "polo",
    ProductPrice = 750
};


Product product3 = new Product();

product3.ProductName = "Ayakkabı";
product3.Category = "Erkek";
product3.ProductBrand = "Adıdas";
product3.ProductPrice = 1650.50f;


Product[] product = new Product[]
{   product1,
    product2,
    product3
};

for (int i = 0; i < product.Length; i++)
{
    Console.WriteLine("Ürün Adı : " + product[i].ProductName);
    Console.WriteLine("Ürün Markası  : " + product[i].ProductBrand);
    Console.WriteLine("Ürün Fiyatı  : " + product[i].ProductPrice);
    Console.WriteLine("Ürün Kategorisi : " + product[i].Category);
    Console.WriteLine("...........................................");
}
Console.WriteLine("...........................................");
Console.WriteLine("...........................................");
foreach (var item in product)
{
    Console.WriteLine("Ürün Adı : " + item.ProductName);
    Console.WriteLine("Ürün Markası  : " + item.ProductBrand);
    Console.WriteLine("Ürün Fiyatı  : " + item.ProductPrice);
    Console.WriteLine("Ürün Kategorisi : " + item.Category);
    Console.WriteLine("...........................................");
}
Console.WriteLine("...........................................");
Console.WriteLine("...........................................");


string[] urunler2 = new string[] { 
    "Model: Macbook Fiyat: 25500 Stok: 3", 
    "Model: Asus Fiyat: 21000 Stok: 5", 
    "Model: HP Fiyat: 23000 Stok: 6", 
    "Model:Casper Fiyat: 19000 Stok: 7" 
};

int dongu = 0;
int a = 1;
while (dongu < urunler2.Length)
{

    Console.WriteLine(urunler2[a]);
    a++;
    dongu++;

};



class Product
{
    public string ProductName { get; set; }
    public float ProductPrice { get; set; }
    public string ProductBrand { get; set; }
    public string Category { get; set; }
}
