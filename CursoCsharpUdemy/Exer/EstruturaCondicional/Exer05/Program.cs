namespace Exer05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código do pedido: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade pedida: ");
            int qty = int.Parse(Console.ReadLine());

            double total = 0.0;
            if (id == 1)
            {
                total = qty * 4.0;
            }
            else if (id == 2)
            {
                total = qty * 4.5;
            }
            else if (id == 3)
            {
                total = qty * 5.0;
            }
            else if (id == 4)
            {
                total = qty * 2.0;
            }
            else if (id == 5)
            {
                total = qty * 1.5;
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }

            Console.WriteLine($"Total: R${total}");
        }
    }
}