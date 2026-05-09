namespace Aula08_Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, 
                triangleArea, circleArea, trapezoidArea, squareArea, rectangleArea;
            double pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            triangleArea = (a * c) / 2.0;

            circleArea = pi * Math.Pow(c, 2);

            trapezoidArea = (a + b) * c / 2.0;

            squareArea = b * b;

            rectangleArea = a * b;

            Console.WriteLine($"TRIANGULO: {triangleArea:F3}");
            Console.WriteLine($"CIRCULO: {circleArea:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezoidArea:F3}");
            Console.WriteLine($"QUADRADO: {squareArea:F3}");
            Console.WriteLine($"RETANGULO: {rectangleArea:F3}");
        }
    }
}
