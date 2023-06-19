namespace TipoReferenciaTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;

            p1.x = 10;
            p1.y = 20;
            Console.WriteLine(p1);

            p1 = new Point();
            Console.WriteLine(p1);
        }
    }
}