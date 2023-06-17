using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Product //Entitiy
    {
        //snippet (prop) hızzlı kod
        //primary key ana anahtar
        public int Id { get; set; }
        //Foreingkey  Referans alanları
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //Fiyat
        public double UnitePrice { get; set; }
        // Stock adeti
        public int UnitsInStock { get; set; }


    }
}
