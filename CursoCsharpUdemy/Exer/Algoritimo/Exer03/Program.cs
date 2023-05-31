/*
 * 3. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a
 * cada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber
 * quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de
 * poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com
 * base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular
 * os dados solicitados. 
 */

namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            double bread, cornBread, total, savings;

            Console.WriteLine("Quantas unidades de pães foram vendidas ? ");
            bread = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas unidades de broas foram vendidas ? ");
            cornBread = double.Parse(Console.ReadLine());

            total = bread * 0.12 + cornBread * 1.50;
            savings = total * 0.1;

            Console.WriteLine($"Foi vendido um total de R${total}");
            Console.WriteLine($"Deve ser guardado R${savings} para a poupança");
        }
    }
}