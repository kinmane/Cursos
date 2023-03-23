/*
*   6) Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
*   temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F representa é a temperatura em graus
*   Fahrenheit e a variável C representa é a temperatura em graus Celsius.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura ? (em fahrenheit)");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit -32) * 5 / 9;

            Console.WriteLine("Essa temperara em Fahrenheit será: " + celsius);
        }
    }
}