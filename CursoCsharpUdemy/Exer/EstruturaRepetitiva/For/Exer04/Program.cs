namespace Exer04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pares a serem lidos:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Digite dois números separados por espaço:");
                string[] values = Console.ReadLine().Split();
                double num1 = double.Parse(values[0]);
                double num2 = double.Parse(values[1]);

                if (num2 == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine(result.ToString("F1"));
                }
            }
        }
    }
}