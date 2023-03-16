using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            // Concatenação
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $" + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $" + preco2);

            Console.WriteLine();

            // PlaceHolders
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);

            Console.WriteLine();

            // Interpolação
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");

            // Concatenação + InvariantCulture
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}