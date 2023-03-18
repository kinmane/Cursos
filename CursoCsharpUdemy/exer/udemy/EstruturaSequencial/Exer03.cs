using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer03
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o primeiro valor inteiro: ");
            int numberA = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor inteiro: ");
            int numberB = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor inteiro: ");
            int numberC = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor inteiro: ");
            int numberD = int.Parse(Console.ReadLine());

            int difference = numberA * numberB - numberC * numberD;

            Console.Write($"Diferença: {difference}");
        }
    }
}