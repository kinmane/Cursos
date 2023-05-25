namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de casos de teste: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Informe os 3 valores separados por espaço: ");
                string[] values = Console.ReadLine().Split();
                double value1 = double.Parse(values[0]);
                double value2 = double.Parse(values[1]);
                double value3 = double.Parse(values[2]);

                double media = (value1 * 2 + value2 * 3 + value3 * 5) / 10;
                Console.WriteLine("Média ponderada: " + media.ToString("F1"));
            }
        }
    }
}