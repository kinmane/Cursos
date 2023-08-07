namespace EstruturaCondicional
{
    public class EstruturaCondicional
    {
        static void Main(string[] args)
        {
            // Simples
            Console.WriteLine("Entre com um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 10)
            {
                Console.WriteLine("Seu numero tem dois dígitos");
            }

            // Composta
            Console.WriteLine("Entre com um número inteiro: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            // Encadeamento
            Console.WriteLine("Qual a hora atual? ");
            int hour = int.Parse(Console.ReadLine());
                            
            if (hour < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}