/*
*   13) Escreva um programa que leia 3 números inteiros e imprima na tela os
*   valores em ordem decrescente.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer13
    {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números inteiros:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine(num1 + " " + num2 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num1 + " " + num3 + " " + num2);
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine(num2 + " " + num1 + " " + num3);
                }
                else
                {
                    Console.WriteLine(num2 + " " + num3 + " " + num1);
                }
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                if (num1 >= num2)
                {
                    Console.WriteLine(num3 + " " + num1 + " " + num2);
                } else
                {
                    Console.WriteLine(num3 + " " + num2 + " " + num1);
                }
            }
        }
    }
}