using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.udemy.IntroduçãoOO
{
    public class Exer02
    {
        static void Main(string[] args)
        {
            ClassExer2 p1 = new ClassExer2();
            ClassExer2 p2 = new ClassExer2();

            Console.WriteLine("Digite os dados do primeiro funcionário:");
            Console.Write("Nome: ")
            p1.Name = Console.ReadLine();
            Console.Write("Sálario: ")
            p1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionário:");
            Console.Write("Nome: ")
            p2.Name = Console.ReadLine();
            Console.Write("Sálario: ")
            p2.Salary = double.Parse(Console.ReadLine());

            averageSalary = (p1.Salary + p2.Salary) / 2;

            Console.WriteLine("A média dos salários é: " + averageSalary);
        }
    }
}