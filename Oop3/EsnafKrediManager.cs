﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : IKrediManager
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi listelendi");
        }
    }
}
