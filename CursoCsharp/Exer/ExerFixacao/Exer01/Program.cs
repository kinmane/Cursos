namespace Exer01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r.Width = double.Parse(Console.ReadLine());
            r.Height = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Area = " + r.Area().ToString("F2"));
            System.Console.WriteLine("Perimetro = " + r.Perimeter().ToString("F2"));
            System.Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2"));
        }
    }
}

