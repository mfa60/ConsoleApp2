using System;
using System.Linq;
namespace MethodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            
            var toplam = Add2(5);
            // int sayi1 = 20;
            int sayi1;
            int sayi2 = 100;
            var toplam2 = Add3(out sayi1, sayi2);
            Console.WriteLine(toplam2);
            Console.WriteLine(sayi1);
            Console.WriteLine(Add4(1,2,4,6,8,2,6,2));
        }
        static void Add() 
        {
            Console.WriteLine("Added !");
        }
        static int Add2(int sayi1=20 , int sayi2=30)
        {
            var toplam = sayi1 + sayi2;
            return toplam;
        }
         static int Add3( out int sayi1 , int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;

        }
        static int Add4(params int[]  sayilar)
        {
            return sayilar.Sum();


        }
    }
}
