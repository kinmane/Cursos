namespace Exer06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor: ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 25.0)
            {
                Console.WriteLine("Intervalor [0, 25]");
            }
            else if (number  <= 50.0)
            {
                Console.WriteLine("Intervalor [25, 50]");
            }
            else if (number  <= 75.0)
            {
                Console.WriteLine("Intervalor [50, 75]");
            }
            else if (number  <= 100.0)
            {
                Console.WriteLine("Intervalor [75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}