namespace Aula11_ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Good Morning");
            if (x < 5) { //false = ignore
                Console.WriteLine("Good Afternoon");
            }
            Console.WriteLine("Good Evening");
        }
    }
}
