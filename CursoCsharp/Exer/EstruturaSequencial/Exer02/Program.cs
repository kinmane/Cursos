namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, radius, area;

            Console.Write("Informe o valor do raio do círculo: ");
            radius = double.Parse(Console.ReadLine());

            area = pi * (radius * radius);

            Console.WriteLine($"Resultado: {area}");
        }
    }
}