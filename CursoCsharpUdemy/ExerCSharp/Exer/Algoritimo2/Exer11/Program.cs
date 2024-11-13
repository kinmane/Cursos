/*
 * 11) Elabore um algoritmo que calcule o que deve ser pago por um produto, 
 * considerando o preço normal deetiqueta e a escolha da condição de pagamento. 
 * Utilize os códigos da tabela a seguir para ler qual acondição de pagamento escolhida
 * e efetuar o cálculo adequado. 
 * Código Condição de pagamento:
 * 1 À vista em dinheiro ou cheque, recebe 10% de desconto
 * 2 À vista no cartão de crédito, recebe 15% de desconto
 * 3 Em duas vezes, preço normal de etiqueta sem juros
 * 4 Em duas vezes, preço normal de etiqueta mais juros de 10%
 */

namespace Exer11
{
      class Program
    {
        static void Main(string[] args)
        {
            double price, finalPrice;
            int condition;

            System.Console.Write("Digite o preço do produto: ");
            price = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a condição de pagamento: ");
            condition = int.Parse(System.Console.ReadLine());

            switch (condition)
            {
                case 1:
                    finalPrice = price * 0.9;
                    System.Console.WriteLine("Preço final: {0}", finalPrice);
                    break;
                case 2:
                    finalPrice = price * 0.85;
                    System.Console.WriteLine("Preço final: {0}", finalPrice);
                    break;
                case 3:
                    System.Console.WriteLine("Preço final: {0}", price);
                    break;
                case 4:
                    finalPrice = price * 1.1;
                    System.Console.WriteLine("Preço final: {0}", finalPrice);
                    break;
                default:
                    System.Console.WriteLine("Condição inválida");
                    break;
            }
        }
    }
}