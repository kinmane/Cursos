/*
* 41) Faça um programa que dada a idade de um nadador, classifique-o em uma das
* seguintes categorias:
*   - Infantil A = 5 a 7 anos
*   - Infantil B = 8 a 11 anos
*   - Juvenil A = 12 a 13 anos
*   - Juvenil B = 14 a 17 anos
*   - Adultos = Maiores de 18 anos
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer41
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do nadador: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string category;
            if (age >= 5 && age <= 7)
            {
                category = "Infantil A";
            }
            else if (age >= 8 && age <= 11)
            {
                category = "Infantil B";
            }
            else if (age >= 12 && age <= 13)
            {
                category = "Juvenil A";
            }
            else if (age >= 14 && age <= 17)
            {
                category = "Juvenil B";
            }
            else
            {
                category = "Adultos";
            }
            Console.WriteLine("Categoria: " + category);
        }
    }
}