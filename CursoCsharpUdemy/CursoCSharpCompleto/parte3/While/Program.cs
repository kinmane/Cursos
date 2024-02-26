namespace While
{
    public class While
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            double numero = double.Parse(Console.ReadLine());

            while (numero >= 0.0)
            {
                double sqrt = Math.Sqrt(numero);
                Console.WriteLine(sqrt.ToString("F3"));
                Console.Write("Informe outro número: ");
                numero = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo!");
        }
    }
}