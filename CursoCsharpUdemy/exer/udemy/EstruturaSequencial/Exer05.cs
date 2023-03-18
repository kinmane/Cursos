using System;

namespace exer.udemy.EstruturaSequencial
{
    public class Exer05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código da peça 1, o número de peças 1, o valor unitário de cada peça 1: ");
            string[] values = Console.ReadLine().Split(' ');
            int code1 = int.Parse(values[0]);
            int qty1 = int.Parse(values[1]);
            double price1 = double.Parse(values[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o código da peça 2, o número de peças 2, o valor unitário de cada peça 2: ");
            values = Console.ReadLine().Split(' ');
            int code2 = int.Parse(values[0]);
            int qty2 = int.Parse(values[1]);
            double price2 = double.Parse(values[2], CultureInfo.InvariantCulture);

            double total = price1 * qty1 + price2 * qty2;

            Console.WriteLine("Total a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}