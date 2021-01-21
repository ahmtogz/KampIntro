using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5,
                UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35, };


            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            // sol taraf Stock           =      sag taraf Heap
           
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //  --------------------------------------------------
            productManager.Topla2(3, 6);
            // iki islem arasinda ki fark alt taraftakinde return kullandigimiz icin toplami baska yerde z.b carpma isleminde kullanmamiza yarar. onu döndürür.
            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamaSonucu*2);
            //-----------------------------
            

        }
    }

} 
