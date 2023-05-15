namespace Exer02;

public class Exer02
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            Console.WriteLine("POSITIVO");
        }
        else
        {
            Console.WriteLine("NEGATIVO");
        }
    }
}