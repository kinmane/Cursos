/*
 * 5) Faça um algoritmo estruturado que leia uma quantidade não determinada de números positivos.
 * alcule a quantidade de números pares e ímpares, a média de valores pares e a média geral dos
 * úmeros lidos. O número que encerrará a leitura será zero. 
 */

namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            int oddCount = 0;
            double evenSum = 0;
            double sumValues = 0;

            Console.WriteLine("Digite os valores (digite 0 para encerrar):");

            while (true)
            {
                double value = double.Parse(Console.ReadLine());

                if (value == 0)
                {
                    break;
                }

                sumValues++;

                if (value % 2 == 0)
                {
                    evenCount++;
                    evenSum += value;
                }
                else
                {
                    oddCount++;
                }
            }

            double evenAverage = evenSum / evenCount;
            double average = sumValues / (evenCount + oddCount);

            Console.WriteLine("Quantidade de números pares: " + evenCount);
            Console.WriteLine("Quantidade de números ímpares: " + oddCount);
            Console.WriteLine("Média dos valores pares: " + evenAverage.ToString("F2"));
            Console.WriteLine("Média geral dos números lidos: " + average.ToString("F2"));
        }
    }
}