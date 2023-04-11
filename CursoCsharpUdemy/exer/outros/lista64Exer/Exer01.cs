/****************************************************************************
*   1-)Faça um programa para calcular o estoque médio de uma peça, sendo que:
*   ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer01
    {
        static void Main(string[] args)
        {
            int qtyMin, qtyMax, stock;
            
            Console.WriteLine("Informe a quantidade mínima de peça: ");
            qtyMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima de peça: ");
            qtyMax = int.Parse(Console.ReadLine());

            stock = (qtyMax + qtyMin) / 2;
            Console.WriteLine("Estoque médio: " + stock);
        }
    }
}