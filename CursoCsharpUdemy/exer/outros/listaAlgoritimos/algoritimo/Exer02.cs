/*
*   2. Faça um algoritmo para calcular quantas ferraduras
*   são necessárias para equipar todos os 
*   cavalos comprados para um haras.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros.listaAlgoritimos.algoritimo
{
    public class Exer02
    {
        static void Main(string[] args) 
        {
            double horseshoe, horse, paw = 4, total;

            Console.WriteLine("Informe quantos cavalos foram comprados: ");
            horse = double.Parse(Console.ReadLine());

            total = paw * horse;

            Console.WriteLine("Total de ferraduras necessárias: " + total);
        }
    }
}