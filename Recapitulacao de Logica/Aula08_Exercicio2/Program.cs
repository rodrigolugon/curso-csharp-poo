namespace Aula08_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi;
            pi = 3.14159;

            //se for usar numero real utilize virgula
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"Valor da área deste círculo: {area:F4} ");
        }
    }
}
