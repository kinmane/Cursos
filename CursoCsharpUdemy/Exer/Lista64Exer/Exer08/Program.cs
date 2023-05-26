/*
 * 8) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
 * V = 3.14159 * R * R * A
 * Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura. 
 */

namespace Exer08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata de óleo: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da lata de óleo: ");
            double height = double.Parse(Console.ReadLine());
            
            double volume = 3.14159 * radius * radius * height;
            
            Console.WriteLine("O volume da lata de óleo é: " + volume);
        }
    }
}