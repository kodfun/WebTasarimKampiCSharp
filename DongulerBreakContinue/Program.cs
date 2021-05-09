using System;

namespace DongulerBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 10'a sayıları yazdır 7 hariç");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7) continue; // increment kısmından devam et
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("1'den 10'a sayıları yazdır, sayı hem 2 hem 3 ile bölünüyorsa döngüyü sonlandır");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                if (i % 2 == 0 && i % 3 == 0)
                    break; // for'u terket
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
