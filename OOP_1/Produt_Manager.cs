using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Produt_Manager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Product_Name + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Product_Name + " Güncellendi.");
        }

    }
}
