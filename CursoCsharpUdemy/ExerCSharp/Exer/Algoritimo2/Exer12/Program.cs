/*
 * 12) Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas por um aluno nas
 * 3 verificações e a média dos exercícios que fazem parte da avaliação, e calcule a média de
 * aproveitamento, usando a fórmula:
 * MA := (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
 * A atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever o número do aluno,
 * suas notas, a média dos exercícios, a média de aproveitamento, o conceito correspondente e a
 * mensagem 'Aprovado' se o conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.
 * Média de aproveitamento Conceito
 * >= 90 A
 * >= 75 e < 90 B
 * >= 60 e < 75 C
 * >= 40 e < 60 D
 * < 40 E 
 */

namespace Exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentId;
            double grade1, grade2, grade3, exerciseAverage;

            Console.WriteLine("Digite o número de identificação do aluno:");
            studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as 3 notas do aluno nas verificações:");
            grade1 = double.Parse(Console.ReadLine());
            grade2 = double.Parse(Console.ReadLine());
            grade3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a média dos exercícios:");
            exerciseAverage = double.Parse(Console.ReadLine());

            double averageScore = (grade1 + grade2 * 2 + grade3 * 3 + exerciseAverage) / 7;

            Console.WriteLine("Número de identificação do aluno: " + studentId);
            Console.WriteLine("Notas do aluno: " + grade1 + ", " + grade2 + ", " + grade3);
            Console.WriteLine("Média dos exercícios: " + exerciseAverage);
            Console.WriteLine("Média de aproveitamento: " + averageScore.ToString("F2"));

            if (averageScore >= 90)
            {
                Console.WriteLine("Conceito: A");
                Console.WriteLine("Aprovado");
            }
            else if (averageScore >= 75)
            {
                Console.WriteLine("Conceito: B");
                Console.WriteLine("Aprovado");
            }
            else if (averageScore >= 60)
            {
                Console.WriteLine("Conceito: C");
                Console.WriteLine("Aprovado");
            }
            else if (averageScore >= 40)
            {
                Console.WriteLine("Conceito: D");
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Conceito: E");
                Console.WriteLine("Reprovado");
            }
        }
    }
}
