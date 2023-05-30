/*
 * 1. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as
 * dimensões de um terreno e depois exibir a área do terreno. 
 */

namespace Algoritimo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do terreno: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do terreno: ");
            double height = double.Parse(Console.ReadLine());
            
            double area = width * height;
            
            Console.WriteLine($"A área do terreno é {area}m²");
        }
    }
}