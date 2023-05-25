namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.Write("Informe o valor do raio do círculo: ");
            double radius = double.Parse(Console.ReadLine());

            double area = pi * (radius * radius);

            Console.WriteLine($"Resultado: {area}");
        }
    }
}