/*
 * 7) Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
 * temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
 * variável C é a temperatura em graus Celsius. 
 */

namespace Exer07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            
            double celsius = (fahrenheit - 32) * 5 / 9;
            
            Console.WriteLine("A temperatura em graus Celsius é: " + celsius);
        }
    }
}