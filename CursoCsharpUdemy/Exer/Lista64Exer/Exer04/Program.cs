/*
 * 4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
 * valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
 * A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
 * com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
 * devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
 * multiplicações. 
 */

namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores numéricos inteiros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sumResult1 = a + b;
            int sumResult2 = a + c;
            int sumResult3 = a + d;
            int sumResult4 = b + c;
            int sumResult5 = b + d;
            int sumResult6 = c + d;

            int multiplicationResult1 = a * b;
            int multiplicationResult2 = a * c;
            int multiplicationResult3 = a * d;
            int multiplicationResult4 = b * c;
            int multiplicationResult5 = b * d;
            int multiplicationResult6 = c * d;

            Console.WriteLine("Resultados das adições:");
            Console.WriteLine("{0} + {1} = {2}", a, b, sumResult1);
            Console.WriteLine("{0} + {1} = {2}", a, c, sumResult2);
            Console.WriteLine("{0} + {1} = {2}", a, d, sumResult3);
            Console.WriteLine("{0} + {1} = {2}", b, c, sumResult4);
            Console.WriteLine("{0} + {1} = {2}", b, d, sumResult5);
            Console.WriteLine("{0} + {1} = {2}", c, d, sumResult6);

            Console.WriteLine("Resultados das multiplicações:");
            Console.WriteLine("{0} * {1} = {2}", a, b, multiplicationResult1);
            Console.WriteLine("{0} * {1} = {2}", a, c, multiplicationResult2);
            Console.WriteLine("{0} * {1} = {2}", a, d, multiplicationResult3);
            Console.WriteLine("{0} * {1} = {2}", b, c, multiplicationResult4);
            Console.WriteLine("{0} * {1} = {2}", b, d, multiplicationResult5);
            Console.WriteLine("{0} * {1} = {2}", c, d, multiplicationResult6);
        }
    }
}