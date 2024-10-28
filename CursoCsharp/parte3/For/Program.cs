namespace For
{
    public class For
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar: ");
            int numero = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= numero; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}