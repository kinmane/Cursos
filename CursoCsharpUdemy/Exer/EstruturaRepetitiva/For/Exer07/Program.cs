namespace Exer07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                int cube = i * i * i;

                Console.WriteLine("{0} {1} {2}", i, square, cube);
            }
        }
    }
}

