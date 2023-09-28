namespace Nullable
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Nullable<double> x = null;
            double? x = null;
            double y = x ?? 10.0;

            Console.WriteLine(x.GetValueOrDefault());

            Console.WriteLine(x.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
        }

    }
}