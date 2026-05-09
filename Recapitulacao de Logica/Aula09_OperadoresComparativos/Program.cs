namespace Aula09_OperadoresComparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10; //condicao1 recebe a condicao
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine("OPERADORES DE MAIOR E MENOR");
            Console.WriteLine($"Condicao 1: {a} < 10 = {c1}");
            Console.WriteLine($"Condicao 2: {a} < 20 = {c2}");
            Console.WriteLine($"Condicao 3: {a} > 10 = {c3}");
            Console.WriteLine($"Condicao 4: {a} > 5 = {c4}");
            Console.WriteLine("--------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10; //compração de igual
            bool c8 = a != 10; //diferente 
            Console.WriteLine("OPERADOR DE MAIOR/MENOR OU IGUAL");
            Console.WriteLine($"Condicao 5: {a} <= 10 = {c5}");
            Console.WriteLine($"Condicao 6: {a} >= 10 = {c6}");
            Console.WriteLine($"Condicao 7: {a} == 10 = {c7}");
            Console.WriteLine($"Condicao 8: {a} != 10 = {c8}");

        }
    }
}
