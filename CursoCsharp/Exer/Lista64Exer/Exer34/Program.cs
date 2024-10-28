/*
 * 34) Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. Suporemos que o
 * número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado para sinalizar o
 * fim dos dados. 
 */

namespace Exer34
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num, maior = 0, menor = 0;
            
            do
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
                }
            } while (num > 0);
            
            System.Console.WriteLine($"Maior número: {maior}");
            System.Console.WriteLine($"Menor número: {menor}");
        }
    }
}