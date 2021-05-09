using System;

namespace IkiSayidanBuyugu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program girilen iki sayıdan hangisinin büyük olduğuna karar verir.");

            Console.Write("Sayı 1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sayı 2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine("Büyük olan: " + sayi1);
            }
            else
            {
                Console.WriteLine("Büyük olan: " + sayi2);
            }

            // İPUCU: if/else kod bloklarında tek bir cümle kod varsa süslü parentezler olmadan da yazılabilir.
            if (sayi1 > sayi2)
                Console.WriteLine($"Büyük olan: {sayi1}");
            else
                Console.WriteLine($"Büyük olan: {sayi2}");

            Console.WriteLine("Büyük olan: " + (sayi1 > sayi2 ? sayi1 : sayi2));

            Console.ReadKey();
        }
    }
}
