namespace Aula10_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOGICAL OPERATORS");
            bool c1 = 2 > 3 && 4 != 5; 
            bool c2 = 2 > 3 || 4 != 5; //true
            bool c3 = ! (2 > 3) && 4 != 5;// true
            bool c4 = ! (2 > 3) || 4 != 5;
            bool c5 = 10 < 5; //false
            //Precedence do AND > OR
            bool c6 = c2 || c3 && c5;

            Console.WriteLine($"Expressão C1: (2 > 3) AND (4 != 5) | Result: {c1}");
            Console.WriteLine($"Expressão C2: (2 > 3) OR (4 != 5) | Result: {c2}");
            Console.WriteLine($"Expressão C3: !(2 > 3) AND (4 != 5) | Result: {c3}");
            Console.WriteLine($"Expressão C4: !(2 > 3) OR (4 != 5) | Result: {c4}");
            Console.WriteLine($"Expressão C6: C2 OR C3 AND C5 | Result: {c6}");


        }
    }
}
