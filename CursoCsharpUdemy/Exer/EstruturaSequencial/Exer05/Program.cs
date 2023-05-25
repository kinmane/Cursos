namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int code1, code2, qty1, qty2;
            double price1, price2, total;

            Console.WriteLine("Informe o código da peça 1, o número de peças e o valor unitário:");
            string[] input1 = Console.ReadLine().Split(' ');
            code1 = int.Parse(input1[0]);
            qty1 = int.Parse(input1[1]);
            price1 = int.Parse(input1[2]);
            
            Console.WriteLine("Informe o código da peça 2, o número de peças e o valor unitário:");
            string[] input2 = Console.ReadLine().Split(' ');
            code2 = int.Parse(input2[0]);
            qty2 = int.Parse(input2[1]);
            price2 = int.Parse(input2[2]);
            
            total = qty1 * price1 + qty2 * price2;

            Console.WriteLine("Total a pagar: R$ " + total.ToString("F2"));
        }
    }
}