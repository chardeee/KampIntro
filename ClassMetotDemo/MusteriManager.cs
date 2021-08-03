using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add( Customer musteri)
        {
            Console.WriteLine( musteri.Ad + " " + musteri.Soyad + " " + "Müşterimiz Bankamıza başarıyla eklenmiştir !");
        }
        public void List(Customer musteri)
        {
            Console.WriteLine(" Bankamızın Aktif Müşterileri Listelenmiştir " + musteri.Ad + musteri.Soyad );
        }
        public void Delete(Customer musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + " " + "Adlı Müşterimiz Bankamızdan Silinmiştir !");
        }
    }   

}
