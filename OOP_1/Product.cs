using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Product
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Product_Name { get; set; } //ürün ismi
        public double Unit_Price { get; set; } // ürün birim fiyatı
        public int Unit_In_Stock { get; set; } //  ürün stok adedi


    }
}
