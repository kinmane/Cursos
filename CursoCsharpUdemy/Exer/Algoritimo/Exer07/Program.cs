/*
 * 7. Entrar com o dia e o mês de uma data e informar quantos dias se passaram desde o início do
 * ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias. 
 */

namespace Exer07
{
    public class Program
    {
        static void Main(string[] args)
        {
            int day, month, daysPassed;

            System.Console.Write("Informe o dia: ");
            day = int.Parse(System.Console.ReadLine());

            System.Console.Write("Informe o mês: ");
            month = int.Parse(System.Console.ReadLine());

            daysPassed = (month - 1) * 30 + day;

            System.Console.WriteLine($"Desde o início do ano, se passaram {daysPassed} dias.");
        }
    }
}