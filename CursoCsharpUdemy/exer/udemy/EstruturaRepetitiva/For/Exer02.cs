using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.For
{
    public class Exer02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro: ");
            int number = int.Parse(Console.ReadLine());

            int countIn = 0;
            int countOut = 0;
            for (int i = 0; i < number; i++)
            {
                inOut = int.Parse(Console.ReadLine());
                if (inOut >= 10 && inOut <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }

            Console.WriteLine(coutIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}