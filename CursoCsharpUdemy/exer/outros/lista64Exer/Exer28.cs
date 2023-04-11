/*
*   28) Faça um programa que gera e escreve os números ímpares dos números lidos
*   entre 100 e 200.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer28
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}