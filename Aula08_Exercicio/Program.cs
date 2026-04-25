using System.Globalization;

namespace Aula08_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string fullname = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa: ");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.Write("Entre com preco de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullname);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
