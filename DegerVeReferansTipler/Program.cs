using System;

namespace DegerVeReferansTipler
{

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



        }
    }


}


// int, decimal, float, double, bool ----> değer tip
// array, class, interface ----> referans tip adresene atanır

// 101|sayilar1 ---> 101| [10,20,30]
// 102|sayilar2 ---> 102| [100,200,300]

// sayilar1 = sayilar2 denildiğinde 
// 102|sayilar1 ---> * 101| [10,20,30] *
// 102|sayilar2 ---> 102| [100,200,300]