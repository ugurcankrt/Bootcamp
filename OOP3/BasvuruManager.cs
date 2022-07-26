﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoglamaServisi> loglamaServisleri)
        {

            krediManager.Hesapla();
            foreach (var loglamaServisi in loglamaServisleri)
            {
                loglamaServisi.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }

    }
}
