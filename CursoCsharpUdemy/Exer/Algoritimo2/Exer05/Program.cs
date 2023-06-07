/*
 * 5) Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo,
 * imprimindo o resultado. 
 */

namespace Exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O dobro de {0} é {1}", num, num * 2);
            }
            else
            {
                Console.WriteLine("O triplo de {0} é {1}", num, num * 3);
            }
        }
    }
}