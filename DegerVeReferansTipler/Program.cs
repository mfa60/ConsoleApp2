using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi = 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayila1[0] = 999

            /*int,float,double değer veri tipleridir
             array , class , inerface referans veri tipleridir
            değer veri tipleri stack te tutulur
            referans veri tipleri heap de tutulur.
            new dediği anda heap de bir alan oluşturulur.
              dizileri biribirine eğiştlediğinde adres kopyalaması yapar
            ve referans numaras değişir.*/
            Console.WriteLine("Hello World!");
        }
    }
}
