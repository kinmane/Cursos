/*
 * 25) Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal,
 * utilizando as seguintes fórmulas: (h = altura)
 * - Para homens: (72.7*h) - 58
 * - Para mulheres: (62.1 *h) - 44.7 
 */

namespace Exer25
{
    public class Program
    {
        static void Main(string[] args)
        {
            double altura = 0;
            char sexo = ' ';

            System.Console.Write("Digite a altura: ");
            altura = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o sexo (M/F): ");
            sexo = char.Parse(System.Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
            {
                System.Console.WriteLine("O peso ideal é: {0}", (72.7 * altura) - 58);
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                System.Console.WriteLine("O peso ideal é: {0}", (62.1 * altura) - 44.7);
            }
            else
            {
                System.Console.WriteLine("Sexo inválido!");
            }
        }
    }
}