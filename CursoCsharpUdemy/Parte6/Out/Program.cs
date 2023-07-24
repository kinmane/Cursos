namespace Out
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            System.Console.WriteLine(a);
        }
    }
}