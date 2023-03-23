/*
*   6) Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
*   temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
*   Fahrenheit e a variável C representa é a temperatura em graus Celsius.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura ? (em celsius)");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("Essa temperara em Fahrenheit será: " + fahrenheit);
        }
    }
}