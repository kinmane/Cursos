namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine($"SOMA = {result}");
        }
    }
}