/*
*   38) Faça um programa que leia as variáveis C e N, respectivamente código e
*   número de horas trabalhadas de um operário. E calcule o salário sabendo-se que
*   ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o
*   excesso de pagamento armazenando-o na variável E, caso contrário zerar tal
*   variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento
*   imprimir o salário total e o salário excedente. O programa só deve parar de
*   rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
*   programa?".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer38
    {
        static void Main(string[] args) {

            int code, hours;
            double salary, extraPayment = 0;

            do {
                Console.Write("Digite o código do trabalhador: ");
                code = Convert.ToInt32(Console.ReadLine());

                if (code == 0) break;

                Console.Write("Digite o número de horas trabalhadas: ");
                hours = Convert.ToInt32(Console.ReadLine());

                if (hours > 50)
                {
                    extraPayment = (hours - 50) * 20.0;
                    hours = 50;
                }
                else
                {
                    extraPayment = 0;
                }

                salary = hours * 10.0 + extraPayment;
                Console.WriteLine("O salário do trabalhador é de R$ {0:F2}. O pagamento extra é R$ {1:F2}.", salary, extraPayment);

                Console.Write("Você quer continuar (S/N)? ");
            } while (Console.ReadLine().Equals("S", StringComparison.OrdinalIgnoreCase));
        }
    }
}