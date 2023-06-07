/*
 * 3) Desenvolver um algoritmo que leia um número não determinado de valores e calcule e escreva a
 * média aritmética dos valores lidos, a quantidade de valores positivos, a quantidade de valores
 * negativos e o percentual de valores negativos e positivos. 
 */

namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valueCount = 0;
            double sumValues = 0;
            int positiveCount = 0;
            int negativeCount = 0;

            Console.WriteLine("Digite os valores (digite 0 para encerrar):");

            while (true)
            {
                double value = double.Parse(Console.ReadLine());

                if (value == 0)
                {
                    break;
                }

                valueCount++;
                sumValues += value;

                if (value > 0)
                {
                    positiveCount++;
                }
                else if (value < 0)
                {
                    negativeCount++;
                }
            }

            double average = sumValues / valueCount;
            double positivePercentage = (positiveCount / (double)valueCount) * 100;
            double negativePercentage = (negativeCount / (double)valueCount) * 100;

            Console.WriteLine("Média aritmética: " + average.ToString("F2"));
            Console.WriteLine("Quantidade de valores positivos: " + positiveCount);
            Console.WriteLine("Quantidade de valores negativos: " + negativeCount);
            Console.WriteLine("Percentual de valores positivos: " + positivePercentage.ToString("F2") + "%");
            Console.WriteLine("Percentual de valores negativos: " + negativePercentage.ToString("F2") + "%");
        }
    }
}