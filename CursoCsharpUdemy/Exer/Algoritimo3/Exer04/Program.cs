/*
 * 4) Escrever um algoritmo que leia uma quantidade desconhecida de números e conte quantos deles
 * estão nos seguintes intervalos: [0-25], [26-50], [51-75] e [76-100]. A entrada de dados deve
 * terminar quando for lido um número negativo. 
 */

namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int interval1Count = 0;
            int interval2Count = 0;
            int interval3Count = 0;
            int interval4Count = 0;

            Console.WriteLine("Digite os valores (digite um valor negativo para encerrar):");

            while (true)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < 0)
                {
                    break;
                }

                if (value >= 0 && value <= 25)
                {
                    interval1Count++;
                }
                else if (value >= 26 && value <= 50)
                {
                    interval2Count++;
                }
                else if (value >= 51 && value <= 75)
                {
                    interval3Count++;
                }
                else if (value >= 76 && value <= 100)
                {
                    interval4Count++;
                }
            }

            Console.WriteLine("Quantidade de valores no intervalo [0-25]: " + interval1Count);
            Console.WriteLine("Quantidade de valores no intervalo [26-50]: " + interval2Count);
            Console.WriteLine("Quantidade de valores no intervalo [51-75]: " + interval3Count);
            Console.WriteLine("Quantidade de valores no intervalo [76-100]: " + interval4Count);
        }
    }
}