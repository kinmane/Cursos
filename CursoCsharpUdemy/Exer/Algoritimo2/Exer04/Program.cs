/*
 * 4) Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se
 * somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se
 * atribuir o resultado para uma variável C e mostrar seu conteúdo na tela. 
 */

namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe o primeiro valor inteiro: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor inteiro: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("A soma dos valores é " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("A multiplicação dos valores é " + c);
            }
        }
    }
}