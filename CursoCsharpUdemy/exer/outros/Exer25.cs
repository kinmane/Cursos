/*
*   25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um
*   programa que calcule seu peso ideal, utilizando as seguintes fórmulas:
*   (h = altura)
*   - Para homens: (72.7*h) - 58
*   - Para mulheres: (62.1 *h) - 44.7
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer25
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura da pessoa (em metros): ");
            doublealtura = double.Parse(Console.ReadLine());

            Console.Write("Digite o sexo da pessoa (M ou F): ");
            string sexo = Console.ReadLine().ToUpper();

            double pesoIdeal;
            if (sexo == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("\nPeso ideal para homem: {0} kg", pesoIdeal);
            }
            else if (sexo == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("\nPeso ideal para mulher: {0} kg", pesoIdeal);
            }
            else
            {
                Console.WriteLine("\nSexo inválido. Tente novamente.");
            }
        }
    }
}