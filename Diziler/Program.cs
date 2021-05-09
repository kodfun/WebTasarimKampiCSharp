using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string dizisi oluştur
            string[] adlar = { "Mahmut", "Sabri", "Zeliha", "Aydın" };

            // yukarıdaki 4 elemanlı bir dizi oluşturduk
            // dizilerin oluşturulduktan sonra boyutu değiştirilemez

            Console.WriteLine("Dizinin uzunluğu: " + adlar.Length);
            Console.WriteLine("2 nolu indeksteki eleman: " + adlar[2]);

            // görev: dizinin son elemanını Ceren olarak değiştir
            adlar[adlar.Length - 1] = "Ceren";

            // görev: dizinin tüm elemanlarını indeks numaralarıyla yazdır
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i, adlar[i]);
            }

            int sabriIndeks = Array.IndexOf(adlar, "Sabri");
            Console.WriteLine("Sabri'nin indeksi: " + sabriIndeks);

            // görev: dizinin elemanlarını alfabetik olarak sırala ve yazdır
            Console.Write("Sıralı: ");
            Array.Sort(adlar);
            foreach (string oge in adlar)
            {
                Console.Write(oge + " ");
            }
            Console.WriteLine();

            // görev: dizinin elemanlarını alfabetik olarak sırala ve yazdır
            Console.Write("Tersten: ");
            Array.Reverse(adlar);
            foreach (string oge in adlar)
            {
                Console.Write(oge + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
