/*
*   21) Faça um programa que leia um número inteiro e mostre uma mensagem na tela
*   indicando se este número é positivo ou negativo. Pare a execução do programa
*   quando o usuário requisitar.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer21
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Informe um número inteiro: ");
            number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("Número positivo");
            }
            else
            {
                Console.WriteLine("Número negativo");
            }
        }
    }
}