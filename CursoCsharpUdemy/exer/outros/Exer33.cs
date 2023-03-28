/*
*   33) Escreva um programa que calcule e exiba a média da nota dos alunos de uma
*   turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno
*   são: número de matrícula e a sua nota na prova em questão.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer33
    {
        static void Main(string[] args)
        {
            int count = 0;
            double total = 0;

            Console.WriteLine("Digite a matrícula e a nota de cada aluno: ");
            while (true) {
                Console.Write("Matrícula (ou 0 para encerrar): ");
                int enrollment = int.Parse(Console.ReadLine());
                if (enrollment ==0) break;

                Console.WriteLine("Digite a nota da prova: ");
                double grade = double.Parse(Console.ReadLine());

                count++;
                total += grade;
            }

            if (count == 0) {
                double media = total / count;
                Console.WriteLine($"Médiada turma: {media.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Não foram digitadas notas.")
            }
        }
    }
}