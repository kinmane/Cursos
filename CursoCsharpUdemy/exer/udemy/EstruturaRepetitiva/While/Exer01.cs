using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.EstruturaRepetitiva.While
{
    public class Exer01
    {
        static void Main(string[] args)
        {
            Console.Write("Senhaenha: ");
            int pass = int.Parse(Console.ReadLine());

            while (pass != 2002)
            {
                Console.WriteLine("Senha Invalida.");
                Console.WriteLine("---------------");
                Console.Write("Informe novamente: ");
                pass = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido.");
        }
    }
}