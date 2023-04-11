/*
*  4. Escreva um algoritmo para ler
*  o nome e a idade de uma pessoa, e exibir quantos dias de vida 
*  ela possui. Considere sempre anos completos,
*  e que um ano possui 365 dias. Ex: uma pessoa 
*  com 19 anos possui 6935 dias de vida;
*  veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros.listaAlgoritimos.algoritimo
{
    public class Exer04
    {
        static void Main(string[] args)
        {
            string name;
            int age, days, years = 365;

            Console.WriteLine("Informe seu nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            age = int.Parse(Console.ReadLine());

            days = age * years;

            Console.WriteLine("Sua idade em dias é: " + days);
        }
    }
}