using System;
using System.Collections.Generic;

namespace OOPGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Ali"; // Ad özelliğinin set accessor'unu kullandık
            kisi1.Soyad = "Yılmaz";
            kisi1.Yas = 33;

            Kisi kisi2 = new Kisi() { Ad = "Ece", Soyad = "Öz", Yas = 22 };

            Console.WriteLine("1. kişinin adı: " + kisi1.Ad); // Ad özelliğinin get'ini kullandık
            Console.WriteLine("2. kişinin yaşı: " + kisi2.Yas); // Yas özelliğinin get'ini kullandık
            Console.WriteLine("1. kişinin künyesi: " + kisi1.Kunye());

            // kişileri listede tutarak sırayla işlem yapabilir miyiz: evet
            List<Kisi> kisiler = new List<Kisi>() { kisi1, kisi2 };
            kisiler.Add(new Kisi() { Ad = "Okan", Soyad = "Göztak", Yas = 21});
            kisiler.Add(new Kisi() { Ad = "Mehmet", Soyad = "Koruk", Yas = 24});
            kisiler.Add(new Kisi() { Ad = "Mahmut", Soyad = "Okutan", Yas = 17});

            // döngüyle listedeki tüm kişilerin künyelerini yazdır
            foreach (Kisi kisi in kisiler)
            {
                Console.WriteLine(kisi.Kunye());
            }

            Console.ReadKey();
        }
    }

    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public string Kunye()
        {
            return Ad + " " + Soyad + " (" + Yas + ")";
        }
    }
}
