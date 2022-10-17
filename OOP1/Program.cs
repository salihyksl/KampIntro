using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Productx product1 = new Productx();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Productx product2 = new Productx { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
