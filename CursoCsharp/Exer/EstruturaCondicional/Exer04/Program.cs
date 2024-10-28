namespace Exer04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int start, final, duration;
            
            Console.WriteLine("Informe a hora inicial do jogo:");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora final do jogo:");
            final = int.Parse(Console.ReadLine());

            duration = 0;
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
}