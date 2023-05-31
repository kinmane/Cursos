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
            double width, height, area;
            
            Console.Write("Digite a largura do terreno: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do terreno: ");
            height = double.Parse(Console.ReadLine());
            
            area = width * height;
            
            Console.WriteLine($"A área do terreno é {area}m²");
        }
    }
}