using System;

namespace OOP_1
{

    class Program
    {


        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category_Id = 2; //mobilya
            product1.Product_Name = "Masa";
            product1.Unit_Price = 500;
            product1.Unit_In_Stock = 3;


            Product product2 = new Product { Id = 2, Category_Id = 5,
                Unit_In_Stock = 5, Product_Name = "Kalem", Unit_Price = 35};

            Produt_Manager produt_manager = new Produt_Manager();
            produt_manager.Add(product1, product2 );



        }

    }


}