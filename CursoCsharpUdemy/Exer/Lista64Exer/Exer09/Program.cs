/*
 * 9) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa
 * pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 
 */

namespace Exer09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade em anos: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade em meses: ");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade em dias: ");
            int days = int.Parse(Console.ReadLine());

            int totalDays = years * 365 + months * 30 + days;

            Console.WriteLine("A idade em dias é: " + totalDays);
        }
    }
}