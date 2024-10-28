/*
 * 5. Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o
 * preço do litro da gasolina e o valor do pagamento, e exibir quantos litros ele conseguiu colocar no tanque. 
 */

namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            double pricePerLiter, payment, liters;

            System.Console.Write("Price per liter: ");
            pricePerLiter = double.Parse(System.Console.ReadLine());

            System.Console.Write("Payment: ");
            payment = double.Parse(System.Console.ReadLine());

            liters = payment / pricePerLiter;

            System.Console.WriteLine($"Liters: {liters}");
        }
    }
}