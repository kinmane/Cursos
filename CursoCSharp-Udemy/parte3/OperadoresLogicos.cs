using System;

namespace parte3
{
    public class OperadoresLogicos
    {
        static void Main(string[] args) 
        {
            bool c1 = 2 > 3 && 4 != 5;
            bool c2 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) || 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}