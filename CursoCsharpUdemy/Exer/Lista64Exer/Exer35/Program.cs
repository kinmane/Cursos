/*
 * 35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10". 
 */

namespace Exer35
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    System.Console.WriteLine("Múltiplo de 10");
                }
            }
        }
    }
}