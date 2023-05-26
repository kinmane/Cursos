/*
 * 41) Faça um programa que dada a idade de um nadador, classifique-o em uma das seguintes categorias:
 * - Infantil A = 5 a 7 anos
 * - Infantil B = 8 a 11 anos
 * - Juvenil A = 12 a 13 anos
 * - Juvenil B = 14 a 17 anos
 * - Adultos = Maiores de 18 anos 
 */

namespace Exer41
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age;

            System.Console.Write("Digite a idade do nadador: ");
            age = int.Parse(System.Console.ReadLine());

            if (age >= 5 && age <= 7)
            {
                System.Console.WriteLine("Infantil A");
            }
            else if (age >= 8 && age <= 11)
            {
                System.Console.WriteLine("Infantil B");
            }
            else if (age >= 12 && age <= 13)
            {
                System.Console.WriteLine("Juvenil A");
            }
            else if (age >= 14 && age <= 17)
            {
                System.Console.WriteLine("Juvenil B");
            }
            else if (age >= 18)
            {
                System.Console.WriteLine("Adultos");
            }
            else
            {
                System.Console.WriteLine("Idade inválida");
            }
        }
    }
}