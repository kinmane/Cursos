/*
*   1. A imobiliária Imóbilis vende apenas terrenos retangulares.
*   Faça um algoritmo para ler as dimensões de um terreno
*   e depois exibir a área do terreno. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros.listaAlgoritimos.algoritimo
{
    public class Exer01
    {
        static void Main(string[] args)
        {
            double width, height, area;

            Console.WriteLine("Digite a largura do terreno: ");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do terreno: ");
            height = double.Parse(Console.ReadLine());

            area = width * height;

            Console.WriteLine("A área do terreno é: " + area);
        }
    }
}