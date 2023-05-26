/*
 * 39) Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar,
 * e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte
 * pergunta, "Deseja encerrar o programa?" . 

 */

namespace Exer39
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            char resposta;
            do
            {
                System.Console.Write("Digite um número inteiro: ");
                numero = int.Parse(System.Console.ReadLine());
                if (numero % 2 == 0)
                {
                    System.Console.WriteLine("O número é par");
                }
                else
                {
                    System.Console.WriteLine("O número é ímpar");
                }
                if (numero >= 0)
                {
                    System.Console.WriteLine("O número é positivo");
                }
                else
                {
                    System.Console.WriteLine("O número é negativo");
                }
                System.Console.Write("Deseja encerrar o programa? (S/N) ");
                resposta = char.Parse(System.Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }
    }
}