/*
 * 18) Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou
 * igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é
 * um valor válido, o programa deve verificar cada código em separado para determinar seu valor por extenso, ou
 * seja, apresentar a mensagem “um”, ”dois” ou “três”. (Utilizar o comando Switch). 

 */

namespace Exer18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }
        }
    }
}