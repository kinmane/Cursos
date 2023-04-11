/*
*   12) Escreva um programa que leia um número inteiro e exiba o seu módulo.
*   O módulo de um número x é:
*   x se x é maior ou igual a zero
*   x * (-1) se x é menor que zero
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("Seu número já é possitivo: " + number);
            }
            else
            {
                number *= -1;
                Console.WriteLine("O módulo do seu número é: " + number);
            }
        }
    }
}