/*
 * 10) O IMC – Indice de Massa Corporal é um critério da Organização Mundial de Saúde 
 * para dar umaindicação sobre a condição de peso de uma pessoa adulta. 
 * A fórmula é IMC = peso / ( altura )2
 * 
 * Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo
 * com a tabela abaixo.
 * IMC em adultos Condição
 * Abaixo de 18,5 Abaixo do peso
 * Entre 18,5 e 25 Peso normal
 * Entre 25 e 30 Acima do peso
 * Acima de 30 obeso 
 */

namespace Exer10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double weight, height, imc;

            Console.Write("Digite o peso: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            height = double.Parse(Console.ReadLine());

            imc = weight / (height * height);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }
    }
}