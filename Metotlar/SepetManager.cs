﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            
            Console.WriteLine("Ürünleriniz sepete eklendi :) " + urun.Adi+" "+ urun.StokAdedi);

        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {

            Console.WriteLine("Ürünleriniz sepete eklendi :) "+ urunAdi);

        }
    
    
    }
}
