/*
*   9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e 
*   dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano
*   com 365 dias e mês com 30 dias.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos anos, meses e dias você tem, separado por espaço. ");
            string[] total = Console.ReadLine().Split(' ');
            int age = int.Parse(total[0]);
            int month = int.Parse(total[1]);
            int days = int.Parse(total[2]);

            int totalDays = (age * 365) + (month * 30) + days;

            Console.WriteLine("Sua idade em dias é: " + totalDays);
        }
    }
}