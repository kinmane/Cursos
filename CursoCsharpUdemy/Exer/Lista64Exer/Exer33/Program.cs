/*
 * 33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de
 * alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.
 */

namespace Exer33
{
    public class Program
    {
        static void Main(string[] args)
        {
            int matricula, qtdAlunos = 0;
            double nota, somaNotas = 0, media;
            do
            {
                System.Console.Write("Digite a matrícula do aluno: ");
                matricula = int.Parse(System.Console.ReadLine());
                if (matricula > 0)
                {
                    System.Console.Write("Digite a nota do aluno: ");
                    nota = double.Parse(System.Console.ReadLine());
                    somaNotas += nota;
                    qtdAlunos++;
                }
            } while (matricula > 0);
            media = somaNotas / qtdAlunos;
            System.Console.WriteLine($"Média da turma: {media}");
        }
    }
}