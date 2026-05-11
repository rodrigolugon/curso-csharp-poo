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

            
            Console.WriteLine("\nDados do produto \n" + produto1);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto1);

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + produto1);
        }
    }
}
