namespace Exer01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int pass;
            
            Console.Write("Senhaenha: ");
            pass = int.Parse(Console.ReadLine());

            while (pass != 2002)
            {
                Console.WriteLine("Senha Invalida.");
                Console.WriteLine("---------------");
                Console.Write("Informe novamente: ");
                pass = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido.");
        }
    }
}