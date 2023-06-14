using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string Adi, string Aciklama, int Fiyat, int StokAdeti)
        {
            Console.WriteLine(" Sepete eklendi : " + Adi);
        }
    }
}
