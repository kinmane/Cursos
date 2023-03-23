/***********************************
*   2) Faça um programa que:
*   - Leia a cotação do dólar
*   - Leia um valor em dólares
*   - Converta esse valor para Real
*   - Mostre o resultado
************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cotação do dolar atual: ");
            double dollar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sálario em dolar: ");
            double salaryDollar = double.Parse(Console.ReadLine());

            double salaryReal = salaryDollar * dollar;

            Console.Write("Seu sálario em real será: " + salaryReal.ToString("F2"));
        }
    }
}