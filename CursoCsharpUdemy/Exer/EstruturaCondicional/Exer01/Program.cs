namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}