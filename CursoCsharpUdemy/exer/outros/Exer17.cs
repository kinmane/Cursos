/*
*   17) Escreva um programa que leia um número inteiro. Verificar por meio de
*   condição se o valor fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o
*   valor fornecido esteja dentro da faixa, apresentar a mensagem “valor válido”.
*   Caso contrário, apresentar a mensagem “valor inválido”.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <=9)
            {
                Console.WriteLine("Número válido");
            }
            else
            {
                Console.WriteLine("Número fora da faixa [0,9]");
            }
        }
    }
}