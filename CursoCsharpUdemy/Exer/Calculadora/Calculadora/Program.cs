namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("Informe o primeiro valor: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    continue;
                }

                Console.WriteLine("Informe o segundo valor: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    continue;
                }

                Console.Clear();

                Console.WriteLine("*------------------*");
                Console.WriteLine("* Selecione:       *");
                Console.WriteLine("* 1- Soma          *");
                Console.WriteLine("* 2- Subtração     *");
                Console.WriteLine("* 3- Multiplicação *");
                Console.WriteLine("* 4- Divisão       *");
                Console.WriteLine("* 0- Sair          *");
                Console.WriteLine("*------------------*");
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {calculadora.Addition(a, b)}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {calculadora.Subtraction(a, b)}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {calculadora.Multiplication(a, b)}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine($"Resultado: {calculadora.Division(a, b)}");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}