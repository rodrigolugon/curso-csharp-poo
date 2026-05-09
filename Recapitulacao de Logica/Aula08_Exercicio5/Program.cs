namespace Aula08_Exercicio5 {
    internal class Program {
        static void Main(string[] args) {
            int codeItem1, codeItem2, quantityItem1, quantityItem2;
            double priceItem1, priceItem2, totalPrice;

            string[] item1 = Console.ReadLine().Split(' ');
            codeItem1 = int.Parse(item1[0]);
            quantityItem1 = int.Parse(item1[1]);
            priceItem1 = double.Parse(item1[2]);

            string[] item2 = Console.ReadLine().Split(' ');
            codeItem2 = int.Parse(item2[0]);
            quantityItem2 = int.Parse(item2[1]);
            priceItem2 = double.Parse(item2[2]);

            totalPrice = (quantityItem1 * priceItem1) + (quantityItem2 * priceItem2);

            Console.WriteLine($"VALOR A PAGAR: R$ {totalPrice:F2}");
        }
    }
}
