namespace Ref
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triplo(ref a);
            System.Console.WriteLine(a);
        }
    }
}