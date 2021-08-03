using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler " + urun.Adi + " Sepete eklendi. " + "Ürün "+ urun.KargoSuresi + " İçinde evinize ulaşacaktır. " + "İyi günler :)" );
        }

        public void Ekle2(string urunAdi, string acıklama,double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
