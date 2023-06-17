using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    public class MyList<T>
    {
        //T tipinde array
        T[] items;
        //MyList class programs.cs'de newlendiği esnada otomatik olarak constructor çalışır.
        public MyList()
        {
            items = new T[0];            
        }
        public void Add(T item)
        {
            //Geçici array referans tutabilmek için
            T[] tempArray = items;
            //ekleme için indek sayısı artırılmalı
            items = new T[items.Length + 1];
            //Geçici araydan eski değerlerimi geri almak için yapılan işlem
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
