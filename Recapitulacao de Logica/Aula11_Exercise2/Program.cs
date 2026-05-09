namespace Aula11_Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("What time is it? ");
            int hour = int.Parse(Console.ReadLine());
            if (hour < 12) {
                Console.WriteLine("Good morning");
            }
            else if (hour < 18) {
                Console.WriteLine("Good afternoon");
            }
            else {
                Console.WriteLine("Good night");
            }
        }
    }
}
