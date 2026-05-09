namespace Aula11_Exercise1 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                Console.WriteLine("EVEN");
            }
            else {
                Console.WriteLine("ODD");
            }
        }
    }
}