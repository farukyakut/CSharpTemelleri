using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager // ProdudctService , 
    {
        public void Add(Product product )
        {
            product.ProductName = "Kamera";
        }

        public void BirseyYap(int sayi)
        {
           sayi = 99;
        }

        public void Add2(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }

        public void update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 +  sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
