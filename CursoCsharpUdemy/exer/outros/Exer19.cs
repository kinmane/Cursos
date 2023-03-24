/*
*   19) Escreva um programa que leia três valores para os lados de um triângulo
*   (variáveis A, B e C). Verificar se cada lado é menor que a soma dos outros dois lados. Se sim,
*   saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B
*   ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo
*   será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores dos lados do triângulo:");
            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b)) {
                if (a == b && b == c) {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (a == b || a == c || b == c) {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }
        }
    }
}