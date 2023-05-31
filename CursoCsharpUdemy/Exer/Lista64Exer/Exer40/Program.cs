/*
 * 40) A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de indústrias que são
 * altamente poluentes do meio ambiente. O índice de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe
 * para 0,3 as indústrias do 1º grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
 * industrias do 1º e 2º grupo são intimadas a suspenderem suas atividades, se o índice atingir 0,5 todos os grupos
 * devem ser notificados a paralisarem suas atividades. Faça um programa que leia o índice de poluição medido e
 * emita a notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar de rodar quando o
 * usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". 
 */

namespace Exer40
{
    public class Program
    {
        static void Main(string[] args)
        {
            double indice;
            char resposta;
            
            do
            {
                System.Console.Write("Digite o índice de poluição medido: ");
                indice = double.Parse(System.Console.ReadLine());
                
                if (indice >= 0.05 && indice <= 0.25)
                {
                    System.Console.WriteLine("Índice de poluição aceitável");
                }
                else if (indice > 0.25 && indice <= 0.3)
                {
                    System.Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades");
                }
                else if (indice > 0.3 && indice <= 0.4)
                {
                    System.Console.WriteLine("Indústrias do 1º e 2º grupo devem suspender suas atividades");
                }
                else if (indice > 0.4 && indice <= 0.5)
                {
                    System.Console.WriteLine("Todos os grupos devem suspender suas atividades");
                }
                System.Console.Write("Deseja encerrar o programa? (S/N) ");
                resposta = char.Parse(System.Console.ReadLine());
                
            } while (resposta == 'N' || resposta == 'n');
        }
    }
}