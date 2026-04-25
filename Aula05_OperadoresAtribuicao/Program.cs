using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primeiro usa e depois incrementa
            int a = 10;
            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("----------");

            //primeiro incrementa e depois usa o valor
            int c = 50;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}