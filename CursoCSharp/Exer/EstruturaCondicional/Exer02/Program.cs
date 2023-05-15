namespace Exer02;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}