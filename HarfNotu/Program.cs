using System;

namespace HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program sınavdan aldığınız puana göre harf notunuzu hesaplar.");
        /*
         * 0 -  44  F
         * 45 - 69  D
         * 70 - 79  C
         * 80 - 89  B
         * 90 - 100 A
         */
        sor:
            Console.Write("Sınavdan aldığınız puan: ");
            decimal puan = Convert.ToDecimal(Console.ReadLine());
            char harfNotu;

            if (puan < 0 || puan > 100)
            {
                Console.WriteLine("Hatalı bir değer girdiniz.");
                goto sor;
            }
            else if (puan < 45)
            {
                harfNotu = 'F';
            }
            else if (puan < 70)
            {
                harfNotu = 'D';
            }
            else if (puan < 80)
            {
                harfNotu = 'C';
            }
            else if (puan < 90)
            {
                harfNotu = 'B';
            }
            else
            {
                harfNotu = 'A';
            }

            Console.WriteLine("Harf notu: " + harfNotu);

            Console.WriteLine("Programdan çıkmak için bir tuşa basınız..");
            Console.ReadKey();
        }
    }
}
