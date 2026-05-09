using System;

namespace Aula08_Exercicio1 {
    internal class Program {
        static void Main(string[] args) {

            int n1, n2, soma;

            Console.WriteLine("VAMOS SOMAR DOIS NUMEROS INTEIROS");
            Console.Write("Digite um numero inteiro: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero inteiro: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine($"A soma de {n1} + {n2} = {soma}" );

        }
    }
}
