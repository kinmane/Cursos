namespace EstruturaCondicional
{
    public class EstruturaCondicional
    {
        static void Main(string[] args)
        {
            // Simples
            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10)
            {
                Console.WriteLine("Seu numero tem dois dígitos");
            }

            // Composta
            Console.WriteLine("Entre com um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            // Encadeamento
            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());
                            
            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
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