using System;
using System.Collections.Generic;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            // listeler diziler gibidir ancak boyutu değiştirilebilir
            List<int> sayilar = new List<int>() { 3, 5, 7, 5 };

            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            Console.WriteLine();


            // listenin başına 2 adet 99 ekle
            sayilar.Insert(0, 99);
            sayilar.Insert(0, 99);
            // listenin sonuna 77 ekle
            sayilar.Add(77);
            // listenin 2. sıradaki (sayma sayısı olarak) elemanını bir arttır
            sayilar[1]++;
            // listedeki ilk gördüğün 5 sayısını sil
            sayilar.Remove(5);
            // listenin ilk elemanını sil
            sayilar.RemoveAt(0);

            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
