/*
 * 10. Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada
 * ponto é um par ordenado (x,y). 
 */

namespace Exer10
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double distance;
            
            Console.WriteLine("Digite as coordenadas do primeiro ponto:");
            Console.Write("x1: ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as coordenadas do segundo ponto:");
            Console.Write("x2: ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            y2 = double.Parse(Console.ReadLine());

            distance = CalculateDistance(x1, y1, x2, y2);

            Console.WriteLine("A distância entre os pontos ({0},{1}) e ({2},{3}) é: {4}", x1, y1, x2, y2, distance);
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

    }
}