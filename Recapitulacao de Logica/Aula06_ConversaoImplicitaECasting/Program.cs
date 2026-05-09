namespace Aula06_ConversaoImplicitaECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);
            Console.WriteLine("----------");

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            Console.WriteLine("-----------");

            int c = 5;
            int d = 2;

            double resultado = (double)c / d;

            Console.WriteLine(resultado);



        }
    }
}
