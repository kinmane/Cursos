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

            int a, b, c, d;
            int sumResult1, sumResult2, sumResult3, sumResult4, sumResult5, sumResult6;
            int multiplicationResult1, multiplicationResult2, multiplicationResult3, multiplicationResult4, multiplicationResult5, multiplicationResult6;

            Console.WriteLine("Digite quatro valores numéricos inteiros:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            sumResult1 = a + b;
            sumResult2 = a + c;
            sumResult3 = a + d;
            sumResult4 = b + c;
            sumResult5 = b + d;
            sumResult6 = c + d;

            multiplicationResult1 = a * b;
            multiplicationResult2 = a * c;
            multiplicationResult3 = a * d;
            multiplicationResult4 = b * c;
            multiplicationResult5 = b * d;
            multiplicationResult6 = c * d;

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