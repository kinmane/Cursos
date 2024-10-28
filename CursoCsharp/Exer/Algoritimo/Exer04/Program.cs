/*
 * 4. Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida
 * ela possui. Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa
 * com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS 
 */

namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            System.Console.Write("Digite seu nome: ");
            name = System.Console.ReadLine();

            System.Console.Write("Digite sua idade: ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"{name}, você já viveu {age * 365} dias.");
        }
    }
}