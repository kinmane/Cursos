/*
*   11) Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos
*   valores de modo que a variável A passe a possuir o valor da variável B, e a
*   variável B passe a possuir o valor da variável A. Apresentar os valores
*   trocados.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int c = b;
            b = a;
            a = c;

            Console.WriteLine("Valores trocados: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}