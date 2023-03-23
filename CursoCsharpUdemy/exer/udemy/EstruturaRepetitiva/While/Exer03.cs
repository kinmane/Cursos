using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.While
{
    public class Exer03
    {
        static void Main(string[] args)
        {
            int option = 0;
            int alcohol = 0;
            int gas = 0;
            int diesel = 0;

            while (option != 4)
            {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1. Álcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Fim");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    alcohol++;
                }
                else if (option == 2)
                {
                    gas++;
                }
                else if (option == 3)
                {
                    diesel++;
                }
                else if (option != 4)
                {
                    Console.WriteLine("Inserir número válido");
                }
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Álcool: " + alcohol);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}