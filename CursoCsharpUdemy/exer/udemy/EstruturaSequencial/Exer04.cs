using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer04
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("Informe o número do funcionário: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas extras: ");
            double hours = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora trabalhada: ");
            double value = double.Parse(Console.ReadLine());

            double salary = hours * value;

            Console.WriteLine($"ID: {id}");
            Console.WriteLine("Salário = R$" + salary.ToString("F2", CultureInfo.InvariantCulture));
        }      
    }
}