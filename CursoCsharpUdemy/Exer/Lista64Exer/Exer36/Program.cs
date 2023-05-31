/*
 * 36) Faça um programa que leia 10 valores inteiros e positivos e:
 * - Encontre o maior valor
 * - Encontre o menor valor
 * - Calcule a média dos números lidos 
 */

namespace Exer356
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num, maior = 0, menor = 0, soma = 0;
            
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write("Digite um número: ");
                num = int.Parse(System.Console.ReadLine());
                
                if (num > 0)
                {
                    if (maior == 0 && menor == 0)
                    {
                        maior = num;
                        menor = num;
                    }
                    else
                    {
                        if (num > maior)
                        {
                            maior = num;
                        }
                        else if (num < menor)
                        {
                            menor = num;
                        }
                    }
                    soma += num;
                }
            }
            
            System.Console.WriteLine($"Maior número: {maior}");
            System.Console.WriteLine($"Menor número: {menor}");
            System.Console.WriteLine($"Média dos números: {soma / 10}");
        }
    }
}