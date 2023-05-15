namespace Exer04;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a hora inicial do jogo:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a hora final do jogo:");
        int final = int.Parse(Console.ReadLine());

        int duration = 0;
        if (start < final)
        {
            duration = final - start;
        }
        else {
            duration = 24 - start + final;
        }

        Console.WriteLine($"O jogo durou {duration} hora(s)");
    }
}