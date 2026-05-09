using System;

namespace Aula04_OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            //+= FUNCIONA COM STRING TAMBEM
            string s = "rodri";
            Console.WriteLine(s);

            s += "go";
            Console.WriteLine(s);
        }
    }
}