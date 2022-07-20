using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>  // T Type in T si
    {
        T[] items;
        // constructor --> ctor --> bir class new lendiğinde çalışan blok
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)  // item = eleman
        {
            T[] tempArray = items; // temp array = geçici dizi. Elemanlar geçici olarak burda tutuluyor ve yeni eleman eklendğinde eski elemanlar isteniyor.
            items = new T[items.Length+1]; // dizinin eleman sayısını bir artırıyorum
            
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item; //aslında eklenmek istenen elemanı şu an ekleyebildim.
            
        }
    }
}


//detaylı anlatımını deftere yazdım.
