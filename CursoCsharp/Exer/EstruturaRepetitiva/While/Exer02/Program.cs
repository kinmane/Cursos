﻿namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Informe as coordenadas: ");
            string[] values = Console.ReadLine().Split(' ');
            x = int.Parse(values[0]);
            y = int.Parse(values[1]);

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
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }
        }
    }
}