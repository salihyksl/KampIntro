using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Productx product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");

        }

        public void Update(Productx product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }
    }
}
