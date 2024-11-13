/*
 * 2) Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. 
 * Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos). 
 */

namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name, sex;
            int maritalStatus;

            Console.WriteLine("Informe seu nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Informe seu sexo: (M/F)");
            sex = Console.ReadLine().ToUpper();
            Console.WriteLine("Informe seu estado civil: ");
            Console.WriteLine("1- Casada");
            Console.WriteLine("2- Solteira");
            maritalStatus = int.Parse(Console.ReadLine());

            if (maritalStatus == 1 && sex == "F")
            {
                Console.WriteLine("Quanto tempo está casada?");
                int time = int.Parse(Console.ReadLine());
            }
            else
            {
                  Console.WriteLine("Você não é casada ou não é mulher.");
            }
        }
    }
}