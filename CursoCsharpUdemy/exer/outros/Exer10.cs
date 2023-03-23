/*
*   Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes 
*   entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igua
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer10
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            bool equal = false;
            bool notEqual = false;
            bool greater = false;
            bool lesser = false;
            bool greaterOrEqual = false;
            bool lesserOrEqual = false;

            if (num1 == num2)
                equal = true;
            if (num1 != num2)
                naoequal = true;
            if (num1 > num2)
                maior = true;
            if (num1 < num2)
                menor = true;
            if (num1 >= num2)
                maiorOuequal = true;
            if (num1 <= num2)
                menorOuequal = true;

            Console.WriteLine("Igual = " + equal);
            Console.WriteLine("Não igual = " + notEqual);
            Console.WriteLine("Maior = " + greater);
            Console.WriteLine("Menor = " + lesser);
            Console.WriteLine("Maior ou igual = " + greaterOrEqual);
            Console.WriteLine("Menor ou igual = " + lesserOrEqual);
        }
    }
}