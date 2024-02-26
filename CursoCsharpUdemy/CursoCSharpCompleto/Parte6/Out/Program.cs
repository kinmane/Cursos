namespace Out
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;
            Calculator.Triplo(a, out triplo);
            System.Console.WriteLine(a);
        }
    }
}