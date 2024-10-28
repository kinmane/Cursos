namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int id;
            double hours, valuePerHour, salary;
            
            Console.WriteLine("Informe o ID do funcionário: ");
            id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o número de horas extras: ");
            hours = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o valor da hora extra: ");
            valuePerHour = double.Parse(Console.ReadLine());

            salary = hours * valuePerHour;

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salário: {salary.ToString("F2")}");
        }
    }
}