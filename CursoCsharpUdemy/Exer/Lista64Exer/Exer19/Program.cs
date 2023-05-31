/*
 * 19) Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
 * lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
 * equilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
 * contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a
 * ocorrência. 

 */

namespace Exer19
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstSide, secondSide, thirdSide;
            
            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo: ");
            secondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            thirdSide = int.Parse(Console.ReadLine());

            if (firstSide < (secondSide + thirdSide) && secondSide < (firstSide + thirdSide) && thirdSide < (firstSide + secondSide))
            {
                if (firstSide == secondSide && secondSide == thirdSide)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }
        }
    }
}