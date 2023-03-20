using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.While
{
    public class Exer02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe as coordenadas: ");
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                }
                else {
                    Console.WriteLine("Quarto");
                }

                values = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}