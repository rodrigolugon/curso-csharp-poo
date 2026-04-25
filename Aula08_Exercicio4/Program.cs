namespace Aula08_Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeId;
            double workedHours, hourlyRate, salary;

            Console.WriteLine("FABRICA DE VIDROS");
            Console.Write("Digite o numero do funcionario: ");
            employeeId = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de horas trabalhadas por esse funcionario: ");
            workedHours = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor da hora nessa empresa: ");
            hourlyRate = double.Parse(Console.ReadLine());

            salary = workedHours * hourlyRate;

            Console.WriteLine("\nDADOS DO FUNCIONARIO");
            Console.WriteLine($"O funcionario de codigo {employeeId} tem um salario de U$: {salary:F2}");

        }
    }
}
