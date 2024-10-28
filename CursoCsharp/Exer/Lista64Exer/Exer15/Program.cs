/*
 * 15) Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
 * aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
 * do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
 * apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
 * apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
 * aluno. 
 */

namespace Exer15
{
    public class Program
    {
        static void Main(string[] args)
        {
            double firstGrade, secondGrade, thirdGrade, fourthGrade, average, recoveryGrade, newAverage;
            
            Console.WriteLine("Digite a primeira nota: ");
            firstGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            secondGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            thirdGrade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            fourthGrade = double.Parse(Console.ReadLine());

            average = (firstGrade + secondGrade + thirdGrade + fourthGrade) / 4;

            if (average >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com média: " + average);
            }
            else
            {
                Console.WriteLine("Digite a nota da recuperação: ");
                recoveryGrade = double.Parse(Console.ReadLine());

                newAverage = (average + recoveryGrade) / 2;

                if (newAverage >= 7)
                {
                    Console.WriteLine("O aluno foi aprovado na recuperação com média: " + newAverage);
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado com média: " + newAverage);
                }
            }
        }
    }
}