using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " ekledi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }   

}
