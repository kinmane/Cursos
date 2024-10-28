/*
 * 30) Faça um programa para imprimir uma tabuada. 
 */

namespace Exer30
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;

            System.Console.Write("Digite um número: ");
            num = int.Parse(System.Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                result = num * i;
                System.Console.WriteLine($"{num} x {i} = {result}");
            }

        }
    }
}