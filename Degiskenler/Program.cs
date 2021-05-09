using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // degiskenler verileri saklamamimizi saglar

            // bir tamsayı değişkeni oluşturduk: variable declaration
            int x;

            // ilk değerini aktaralım: initialization
            x = 3;

            int y = 4; // değişken oluşturduk ve değerini atadık (assign)

            // + aritmetik operatörü ile toplama işlemi yapalım
            int toplam = x + y; // x + y ifadesinin sonucunu toplam değişkenine ata

            Console.Write("Toplam: ");
            Console.WriteLine(toplam);

        }
    }
}
