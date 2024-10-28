/*
 * 8. Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir a sua média
 * ponderada (as notas tem pesos respectivos de 1, 2 e 3). 
 */

namespace Exer08
{
    public class Program
    {
        static void Main(string[] args)
        {
            double grade1, grade2, grade3, media;

            System.Console.Write("Digite a primeira nota: ");
            grade1 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a segunda nota: ");
            grade2 = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a terceira nota: ");
            grade3 = double.Parse(System.Console.ReadLine());

            media = (grade1 + grade2 + grade3) / 3;

            System.Console.WriteLine($"A média é {media}");
        }
    }
}