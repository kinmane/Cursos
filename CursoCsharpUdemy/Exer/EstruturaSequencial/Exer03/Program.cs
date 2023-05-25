namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB, numberC, numberD, difference;
            
            Console.Write("Informe o primeiro valor inteiro: ");
            numberA = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor inteiro: ");
            numberB = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor inteiro: ");
            numberC = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor inteiro: ");
            numberD = int.Parse(Console.ReadLine());

            difference = numberA * numberB - numberC * numberD;

            Console.Write($"Diferença: {difference}");
        }
    }
}