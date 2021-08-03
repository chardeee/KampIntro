using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public int Id { get; set; }
        private string _ad;
        public string Ad
        {
            get { return "Sayın" + _ad; }
            set { _ad = value; }
        }
        public string Soyad { get; set; }
        public int Yaş { get; set; }
    }
}
