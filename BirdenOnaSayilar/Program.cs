using System;

namespace BirdenOnaSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1; // İLK DEĞER ATAMA
            int max = 10;

            // şart doğru olduğu sürece altındaki kod blogunu çalıştır
            while (sayi <= max) // KOŞUL
            {
                Console.Write(sayi + " ");
                // sayi += 1; // sayi = sayi + 1;
                sayi++; // ARTTIRMA
            }
            Console.WriteLine();

            // for ( ilk_değer_atama ; şart ; arttirma/azaltma )
            //      şart_doğru_ise_çalışacak_kod
            for (int i = 1; i <= max; i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
