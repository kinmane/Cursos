/*
*   20) Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor
*   maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler
*   novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo
*   menor.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer20
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite três valores inteiros maiores que zero:");

            Console.Write("Valor para a: ");
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Valor inválido para a. Digite novamente.");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Valor para b: ");
            b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Valor inválido para b. Digite novamente.");
                b = int.Parse(Console.ReadLine());
            }

            Console.Write("Valor para c: ");
            c = int.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Valor inválido para c. Digite novamente.");
                c = int.Parse(Console.ReadLine());
            }

            int menor = a, maior = a;

            if (b < menor) menor = b;
            if (c < menor) menor = c;

            if (b > maior) maior = b;
            if (c > maior) maior = c;

            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Produto do menor pelo maior: {menor * maior}");
            Console.WriteLine($"Maior dividido pelo menor: {(double)maior / menor}");
        }
    }
}