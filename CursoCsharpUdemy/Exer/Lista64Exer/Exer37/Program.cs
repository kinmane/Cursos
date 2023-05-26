/*
 * 37) Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as
 * seguintes opções:
 * 1 – Adição
 * 2 – Subtração
 * 3 – Multiplicação
 * 4 – Divisão
 * Informe a opção:
 * A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, o
 * programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao
 * menu principal. Caso a resposta seja ´S´ ou ´s´, deverá voltar ao menu, caso contrário deverá encerrar o
 * programa. 
 */

namespace Exer37
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double num1, num2, resultado;
            char resposta;
            do
            {
                System.Console.WriteLine("1 – Adição");
                System.Console.WriteLine("2 – Subtração");
                System.Console.WriteLine("3 – Multiplicação");
                System.Console.WriteLine("4 – Divisão");
                System.Console.Write("Informe a opção: ");
                opcao = int.Parse(System.Console.ReadLine());
                System.Console.Write("Digite o primeiro número: ");
                num1 = double.Parse(System.Console.ReadLine());
                System.Console.Write("Digite o segundo número: ");
                num2 = double.Parse(System.Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        System.Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        System.Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        System.Console.WriteLine($"Resultado: {resultado}");
                        break;
                    case 4:
                        resultado = num1 / num2;
                        System.Console.WriteLine($"Resultado: {resultado}");
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!");
                        break;
                }
                System.Console.Write("Deseja voltar ao menu principal? (S/N) ");
                resposta = char.Parse(System.Console.ReadLine());
            } while (resposta == 'S' || resposta == 's');
        }
    }
}