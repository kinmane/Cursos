/*
 * 1) Faça um programa para calcular o estoque médio de uma peça, sendo que:
 * ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2. 
 */

namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtyMin, qtyMax;
            double avarege;
            
            Console.WriteLine("Digite a quantidade mínima: ");
            qtyMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima: ");
            qtyMax = int.Parse(Console.ReadLine());

            avarege = (qtyMin + qtyMax) / 2;

            Console.WriteLine("O estoque médio é: " + avarege);
        }
    }
}