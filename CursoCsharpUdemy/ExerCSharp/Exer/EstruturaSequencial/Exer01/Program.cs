namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result;
            
            Console.Write("Digite um número inteiro: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: ");
            number2 = int.Parse(Console.ReadLine());

            result = number1 + number2;

            Console.WriteLine($"SOMA = {result}");
        }
    }
}