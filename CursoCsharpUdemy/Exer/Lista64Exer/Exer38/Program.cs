/*
 * 38) Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um
 * operário. E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a
 * 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora
 * excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. O
 * programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
 * programa?". 
 */

namespace Exer38
{
    public class Program
    {
        static void Main(string[] args)
        {
            int C, N, E;
            double salario, salarioExcedente;
            char resposta;
            do
            {
                System.Console.Write("Digite o código do operário: ");
                C = int.Parse(System.Console.ReadLine());
                System.Console.Write("Digite o número de horas trabalhadas: ");
                N = int.Parse(System.Console.ReadLine());
                if (N > 50)
                {
                    E = N - 50;
                    salario = 50 * 10;
                    salarioExcedente = E * 20;
                    System.Console.WriteLine($"Salário total: {salario + salarioExcedente}");
                    System.Console.WriteLine($"Salário excedente: {salarioExcedente}");
                }
                else
                {
                    salario = N * 10;
                    System.Console.WriteLine($"Salário total: {salario}");
                    System.Console.WriteLine($"Salário excedente: 0");
                }
                System.Console.Write("Deseja encerrar o programa? (S/N) ");
                resposta = char.Parse(System.Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }
    }
}