/*
 * 42) Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de
 * um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO). 
 */

namespace Exer42
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0, menor = 0;
            
            do
            {
                System.Console.Write("Digite um número: ");
                n = int.Parse(System.Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                }
                if (n < menor)
                {
                    menor = n;
                }
            } while (n != 0);
            
            System.Console.WriteLine($"Maior: {maior}");
            System.Console.WriteLine($"Menor: {menor}");
        }
    }
}