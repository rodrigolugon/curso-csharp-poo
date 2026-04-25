using System;
using System.Globalization;

namespace Aula01_TiposDeDados //NOME DO PROJETO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TIPOS DE DADOS
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            //TIPOS DE DADOS

            //SAIDA DE DADOS
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            //SAIDA DE DADOS

            int n1 = int.MaxValue;
            int n2 = int.MinValue;
            long n3 = 1548855855L;
            float n4 = 4.5f;
            double n5 = 4.5896;
            string nome = "Rodrigo Alves Lugon";
            object obj1 = "Professora Flavia";
            object obj2 = 9.8f;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5.ToString("F2"));
            Console.WriteLine(n5.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            
        }
    }
}