/*
*   35) Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma
*   mensagem: "Múltiplo de 10".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer35
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
            }
        }
    }
}