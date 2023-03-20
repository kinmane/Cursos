using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaCondicional
{
    public class Exer04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora inicial do jogo:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora final do jogo:");
            int final = int.Parse(Console.ReadLine());

            int duration = 0;
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