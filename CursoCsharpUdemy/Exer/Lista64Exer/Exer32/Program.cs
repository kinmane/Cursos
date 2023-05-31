/*
 * 32) Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
 8 ímpares a partir do número informado pelo usuário menor que 10 e maior que zero. 
 */

namespace Exer32;

public class Program
{
    private static void Main(string[] args)
    {
        int num, soma = 0;
        
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        if (num > 0 && num < 10)
        {
            for (var i = 0; i < 20; i++)
            {
                if (num % 2 != 0) soma += num * num;
                num++;
            }

            Console.WriteLine($"Soma dos quadrados dos 20 primeiros números ímpares a partir de {num - 20}: {soma}");
        }
        else
        {
            Console.WriteLine("Número inválido!");
        }
    }
}