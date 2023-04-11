/*
*   44) Faça um programa que exiba as opções:
*   1 – Conversão de Graus Celsius em Graus Fahrenheit
*   2 – Conversão de Graus Fahrenheit em Graus Celsius
*   3 – Peso ideal do homem
*   4 – Peso ideal da mulher
*   O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta
*   “Deseja encerrar o programa?”
*   Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer44
    {
        static void Main(string[] args) {
        char continuar;
        do {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
            Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
            Console.WriteLine("3 - Peso ideal do homem");
            Console.WriteLine("4 - Peso ideal da mulher");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em graus Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (9.0 / 5.0) * celsius + 32;
                    Console.WriteLine($"Temperatura em graus Fahrenheit: {fahrenheit}");
                    break;
                case 2:
                    Console.Write("Digite a temperatura em graus Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (5.0 / 9.0) * (fahrenheit - 32);
                    Console.WriteLine($"Temperatura em graus Celsius: {celsius}");
                    break;
                case 3:
                    Console.Write("Digite a altura em metros: ");
                    double altura = double.Parse(Console.ReadLine());
                    double pesoIdealHomem = 72.7 * altura - 58;
                    Console.WriteLine($"Peso ideal do homem: {pesoIdealHomem} kg");
                    Console.Write("Digite o peso atual em kg: ");
                    double pesoAtualHomem = double.Parse(Console.ReadLine());
                    if (pesoAtualHomem < pesoIdealHomem)
                    {
                        Console.WriteLine("Você está abaixo do peso ideal.");
                    }
                    else if (pesoAtualHomem > pesoIdealHomem)
                    {
                        Console.WriteLine("Você está acima do peso ideal.");
                    }
                    else
                    {
                        Console.WriteLine("Você está no peso ideal.");
                    }
                    break;
                case 4:
                    Console.Write("Digite a altura em metros: ");
                    altura = double.Parse(Console.ReadLine());
                    double pesoIdealMulher = 62.1 * altura - 44.7;
                    Console.WriteLine($"Peso ideal da mulher: {pesoIdealMulher} kg");
                    Console.Write("Digite o peso atual em kg: ");
                    double pesoAtualMulher = double.Parse(Console.ReadLine());
                    if (pesoAtualMulher < pesoIdealMulher)
                    {
                        Console.WriteLine("Você está abaixo do peso ideal.");
                    }
                    else if (pesoAtualMulher > pesoIdealMulher)
                    {
                        Console.WriteLine("Você está acima do peso ideal.");
                    }
                    else
                    {
                        Console.WriteLine("Você está no peso ideal.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.Write("Deseja encerrar o programa? (S/N) ");
            continuar = Console.ReadLine()[0];
        } while (continuar != 'S' && continuar != 's');
    }
    }
}