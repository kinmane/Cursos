/*
 * 9) Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
 * calcule seu peso ideal, utilizando as seguintes fórmulas:
 * ● para homens: (72.7 * h) – 58;
 * ● para mulheres: (62.1 * h) – 44.7. 
 */

namespace Exer09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double height, idealWeight;
            char sex;

            Console.Write("Digite a altura: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Digite o sexo (M/F): ");
            sex = char.Parse(Console.ReadLine());

            if (sex == 'M' || sex == 'm')
            {
                idealWeight = (72.7 * height) - 58;
            }
            else
            {
                idealWeight = (62.1 * height) - 44.7;
            }

            Console.WriteLine("O peso ideal é {0}", idealWeight);
        }
    }
}