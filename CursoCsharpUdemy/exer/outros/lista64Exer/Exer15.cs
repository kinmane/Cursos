using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer.outros
{
    public class Exer15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe suas notas entre espaços: (0 a 10)");
            string[] values = Console.ReadLine().Split(' ');
            int grade1 = int.Parse(values[0]);
            int grade2 = int.Parse(values[1]);
            int grade3 = int.Parse(values[2]);
            int grade4 = int.Parse(values[3]);

            int media = (grade1 + grade2 + grade3 + grade4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado, media: " + media);
            }
            else
            {
                Console.WriteLine("Informe a nota da recuperação: ");
                int recovery = int.Parse(Console.ReadLine());

                int newMedia = (media + recovery) / 2;

                if (newMedia >= 7)
                {
                Console.WriteLine("Aprovado com recuperação, media: " + newMedia);
                }
                else
                {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Media com recuperação: " + newMedia);
                }
            }
        }
    }
}