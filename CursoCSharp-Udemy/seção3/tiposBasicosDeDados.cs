using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            // 0 até 255
            byte n1 = 126;
            Console.WriteLine(n1);

            // -128 até 127
            sbyte n2 = 100;
            Console.WriteLine(n2);  

            // -32.768 até 32.767
            short n3 = 1000;
            Console.WriteLine(n3);  

            // 0 até 65.535
            ushort n4 = 1000;
            Console.WriteLine(n4);  

            // -2.147.483.648 até 2.147.483.648
            int n5 = 10000;
            Console.WriteLine(n5);  

            // 0 até 4.294.967.295
            uint n6 = 10000;
            Console.WriteLine(n6);  

            // -9.223.372.036.854.775.808 até 9.223.372.036.854.775.808
            long n7 = 100000;
            Console.WriteLine(n7);  

            // 0 até 18.446.744.073.709.551.615
            ulong n8 = 100000;
            Console.WriteLine(n8);  

            // -3.402856e38 até 3.402856e38
            float n9 = 1000000;
            Console.WriteLine(n9);  

            // -1.79769313486232e308 até 1.79769313486232e308
            double n10 = 10000000;
            Console.WriteLine(n10);  

            // -79228162514264337593543950335 até 79228162514264337593543950335
            decimal n11 = 100000000;
            Console.WriteLine(n11);  

            // Um caractere unicode
            char n12 = '\u0041';
            Console.WriteLine(n12);  

            // True ou False
            bool n13 = true;
            Console.WriteLine(n13); 

        }
    }
}