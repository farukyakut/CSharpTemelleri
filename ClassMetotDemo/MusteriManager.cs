using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+ " Bey kaydınız oluşturuldu");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " Bey kaydınız Silindi");
        }

        public void Güncelleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " Bey kaydınız Güncellendi");
        }
    }
}
