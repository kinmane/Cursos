/*
 * 44) Faça um programa que exiba as opções:
 * 1 – Conversão de Graus Celsius em Graus Fahrenheit
 * 2 – Conversão de Graus Fahrenheit em Graus Celsius
 * 3 – Peso ideal do homem
 * 4 – Peso ideal da mulher
 * O programa só deve encerrar quando o usuário digitar ´S´ para a pergunta “Deseja encerrar o programa?”
 * Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal. 
 */

namespace Exer44
{
    public class Program
    {
        static void Main(string[] args)
        {
            char encerrar = 'N';

            do
            {
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");

                Console.Write("Escolha uma opção (1-4): ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = CelsiusParaFahrenheit(celsius);
                        Console.WriteLine("A temperatura em Fahrenheit é: {0}°F", fahrenheit);
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        double fahrenheit2 = double.Parse(Console.ReadLine());
                        double celsius2 = FahrenheitParaCelsius(fahrenheit2);
                        Console.WriteLine("A temperatura em Celsius é: {0}°C", celsius2);
                        break;
                    case 3:
                        Console.Write("Digite a altura em metros: ");
                        double alturaHomem = double.Parse(Console.ReadLine());
                        double pesoIdealHomem = CalcularPesoIdealHomem(alturaHomem);
                        Console.WriteLine("O peso ideal para um homem de altura {0}m é: {1}kg", alturaHomem,
                                        pesoIdealHomem);
                        Console.WriteLine("O usuário está {0} do peso ideal.",
                                        VerificarPesoIdeal(alturaHomem, pesoIdealHomem));
                        break;
                    case 4:
                        Console.Write("Digite a altura em metros: ");
                        double alturaMulher = double.Parse(Console.ReadLine());
                        double pesoIdealMulher = CalcularPesoIdealMulher(alturaMulher);
                        Console.WriteLine("O peso ideal para uma mulher de altura {0}m é: {1}kg", alturaMulher,
                                        pesoIdealMulher);
                        Console.WriteLine("O usuário está {0} do peso ideal.",
                                        VerificarPesoIdeal(alturaMulher, pesoIdealMulher));
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Write("Deseja encerrar o programa? (S/N): ");
                encerrar = Console.ReadLine().ToUpper()[0];
            } while (encerrar != 'S');
        }

        static double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CalcularPesoIdealHomem(double altura)
        {
            return (72.7 * altura) - 58;
        }

        static double CalcularPesoIdealMulher(double altura)
        {
            return (62.1 * altura) - 44.7;
        }

        static string VerificarPesoIdeal(double altura, double pesoIdeal)
        {
            double pesoAtual = 0;
            Console.Write("Digite o peso atual em kg: ");
            pesoAtual = double.Parse(Console.ReadLine());
            if (pesoAtual < pesoIdeal)
            {
                return "abaixo";
            }
            else if (pesoAtual > pesoIdeal)
            {
                return "acima";
            }
            else
            {
                return "no";
            }
        }
    }
}