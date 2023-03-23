/*************************************************************************
*   4) Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
*   valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
*   A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
*   com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
*   devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as multiplicações.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer04
    {
        static void Main(string[] args) // Desisto
        {
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de D: ");
        int d = int.Parse(Console.ReadLine());
        
        int ab = a + b;
        int ac = a + c;
        int ad = a + d;
        int bc = b + c;
        int bd = b + d;
        int cd = c + d;
        
        int abMult = a * b;
        int acMult = a * c;
        int adMult = a * d;
        int bcMult = b * c;
        int bdMult = b * d;
        int cdMult = c * d;
        
        Console.WriteLine($"A soma de A+B é {ab}");
        Console.WriteLine($"A soma de A+C é {ac}");
        Console.WriteLine($"A soma de A+D é {ad}");
        Console.WriteLine($"A soma de B+C é {bc}");
        Console.WriteLine($"A soma de B+D é {bd}");
        Console.WriteLine($"A soma de C+D é {cd}");
        
        Console.WriteLine($"A multiplicação de A*B é {abMult}");
        Console.WriteLine($"A multiplicação de A*C é {acMult}");
        Console.WriteLine($"A multiplicação de A*D é {adMult}");
        Console.WriteLine($"A multiplicação de B*C é {bcMult}");
        Console.WriteLine($"A multiplicação de B*D é {bdMult}");
        Console.WriteLine($"A multiplicação de C*D é {cdMult}");
        }
    }
}