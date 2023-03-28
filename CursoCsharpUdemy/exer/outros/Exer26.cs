/*
*   26) Escreva um programa que exiba os números de 1 a 100 na tela em ordem
*   decrescente.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer26
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}