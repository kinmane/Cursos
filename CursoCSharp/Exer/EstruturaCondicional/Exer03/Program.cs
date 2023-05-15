namespace Exer03;

public class Program
{
    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split(' ');
        int a = int.Parse(values[0]);
        int b = int.Parse(values[1]);

        if (a % b == 0 || b % a == 0) {
            Console.WriteLine("São multiplos");
        }
        else
        {
            Console.WriteLine("Não são multiplos");
        }
    }
}