namespace SemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY;
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
        
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());            
            x.C = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            
            areaX = x.Area();
            
            areaY = y.Area();
            
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

