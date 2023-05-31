/*
 * 6) Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
 * temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
 * Fahrenheit e a variável C representa é a temperatura em graus Celsius. 
 */

namespace Exer06
{
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            
            fahrenheit = (9 * celsius + 160) / 5;
            
            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit);
        }
    }
}