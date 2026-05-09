using System.Globalization;
    namespace Aula13_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (x >= 0) {
            
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"));
                Console.Write("Digite um numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Numero Negativo");    
        }
    }
}
