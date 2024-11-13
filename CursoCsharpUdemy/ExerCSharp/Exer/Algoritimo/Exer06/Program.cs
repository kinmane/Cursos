/*
 * 6. O restaurante a quilo Bem-Bão cobra R$12,00 por cada quilo de refeição. Escreva um algoritmo
 * que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a
 * balança já desconte o peso do prato. 
 */

namespace Exer06
{
    public class Program
    {
        static void Main(string[] args)
        {
            double pricePerKg = 12.00;
            double weight = 0.0;
            double total = 0.0;
            
            System.Console.Write("Peso do prato (kg): ");
            weight = double.Parse(System.Console.ReadLine());
            
            total = weight * pricePerKg;
            
            System.Console.WriteLine("Total a pagar: R$ {0}", total);
        }
    }
}