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
            double dollar, salaryDollar, salaryReal;

            Console.WriteLine("Informe a cotação do dolar atual: ");
            dollar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sálario em dolar: ");
            salaryDollar = double.Parse(Console.ReadLine());

            salaryReal = salaryDollar * dollar;

            Console.Write("Seu sálario em real será: " + salaryReal.ToString("F2"));
        }
    }
}