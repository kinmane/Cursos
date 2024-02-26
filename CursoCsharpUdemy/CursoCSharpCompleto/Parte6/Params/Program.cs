namespace Params
{
    public class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(2, 3);
            int s2 = Calculator.Soma(2, 4, 3);
            
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}