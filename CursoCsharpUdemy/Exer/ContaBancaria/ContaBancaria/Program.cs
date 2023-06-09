namespace ContaBancaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number;
            string name;
            char response;
            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com onome do titular da conta: ");
            name = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            response = char.Parse(Console.ReadLine().ToUpper());

            if (response == 'S')
            {
                double initialDeposit;

                Console.WriteLine("Entre o valor de depósito inicial: ");
                initialDeposit = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(number, name, initialDeposit);
            }
            else
            {
                conta = new ContaBancaria(number, name);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    }
}