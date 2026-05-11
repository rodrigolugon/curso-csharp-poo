using System.Globalization;
namespace Aula03_ExercicioProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(); //intanciacao

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: ");

        }
    }
}
