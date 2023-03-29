/*
*   42) Faça um programa que determine o maior e o menor entre N números lidos.
*   A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar
*   executando até que a entrada seja igual a 0 (ZERO).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer42
    {
        public static void Main (string[] args)
        {
            int number, bigger = int.MinValue, smaller = int.MaxValue;
            
            do {
                Console.Write("Digite um número (ou 0 para parar): ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    if (number > bigger) {
                    bigger = number;
                    }
                    if (number < smaller) {
                    smaller = number;
                    }
                }
                } while (number != 0);
                if (bigger == int.MinValue)
                {
                Console.WriteLine("Nenhum número foi digitado.");
                }
                else
                {
                Console.WriteLine("Maior número: " + bigger);
                Console.WriteLine("Menor número: " + smaller);
            }
        }
    }
}