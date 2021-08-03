using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //snippet
    class Product
    {
        public int Id { get; set; }
        //hangi kategoriye ait ürün oldugu
        public int CategoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //ürünün fiyatı
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitsInStock { get; set; }

        //CRUD

    }
}
