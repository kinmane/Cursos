namespace ComOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double xA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y");
            double yA = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Áreas iguais");
            }
        }
    }
}