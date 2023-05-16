using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.IntroduçãoOO
{
    public class Exer01
    {
        static void Main(string[] args)
        {
            ClassExer01 p1 = new ClassExer01();
            ClassExer01 p2 = new ClassExer01();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Name);
            }
        }
    }
}