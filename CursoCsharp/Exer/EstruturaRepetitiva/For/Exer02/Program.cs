namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de valores a serem lidos:");
            int n = int.Parse(Console.ReadLine());

            int withinInterval = 0;
            int outsideInterval = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o valor {0}:", i + 1);
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                    withinInterval++;
                else
                    outsideInterval++;
            }

            Console.WriteLine("Valores dentro do intervalo: {0}", withinInterval);
            Console.WriteLine("Valores fora do intervalo: {0}", outsideInterval);
        }
    }
}

