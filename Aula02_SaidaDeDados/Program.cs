using System;

namespace Aula02_SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //MAIS POPULAR
            Console.WriteLine($"{nome} tem {idade} anos e um saldo igual a {saldo:F2} reais");

            Console.WriteLine("----------");
            //MENOS POPULAR
            Console.WriteLine("{0} tem {1} anos e um saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine(nome+ " tem " +idade+ " anos e um saldo igual a " +saldo.ToString("F2")+ " reais");
        }
    }
}