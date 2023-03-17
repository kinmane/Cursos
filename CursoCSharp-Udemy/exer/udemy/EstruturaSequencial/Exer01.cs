using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer01
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