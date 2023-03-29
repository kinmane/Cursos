/*
*   22) Faça um programa que leia um número. Se positivo armazene-o em A, se for
*   negativo, em B. No final mostrar o resultado.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer22
    {
        static void Main(string[] args) {
            int a = 0, b = 0, number;

            Console.WriteLine("Informe um número: ");
            number = int.Parse(Console.ReadLine());

            if (number >= 0) {
                a = number;
                Console.WriteLine("O número era positivo e foi armazenado na variável 'A': " + a);
            } else {
                b = number;
                Console.WriteLine("O número era negativo e foi armazenado na variável 'B': " + b);
            }
        }
    }
}