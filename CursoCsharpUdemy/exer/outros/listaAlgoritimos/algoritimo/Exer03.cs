/*
3.  A padaria Hotpão vende uma certa quantidade de pães franceses
*   e uma quantidade de broas a cada dia. 
*   Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. 
*   Ao final do dia, o dono quer saber 
*   quanto arrecadou com a venda dos pães e broas (juntos),
*   e quanto deve guardar numa conta de 
*   poupança (10% do total arrecadado). 
*   Você foi contratado para fazer os cálculos para o dono. 
*   Com base nestes fatos, faça um algoritmo
*   para ler as quantidades de pães e de broas, e depois calcular 
*   os dados solicitados
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros.listaAlgoritimos.algoritimo
{
    public class Exer03
    {
        static void Main(string[] args)
        {
            //em pt-br esse por falta de criatividade para colocar em inglês
            int paes, broas;
            double valorPaes = 0.12, valorBroa = 1.50, total, poupanca;

            Console.WriteLine("Quantos pães foram comprados: ");
            paes = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos broas foram comprados: ");
            broas = int.Parse(Console.ReadLine());

            total = paes * valorPaes + broas * valorBroa;
            poupanca = total * 0.1;
            
            Console.WriteLine("Total arrecadado: " + total);
            Console.WriteLine("Poupanca: " + poupanca);
        }
    }
}