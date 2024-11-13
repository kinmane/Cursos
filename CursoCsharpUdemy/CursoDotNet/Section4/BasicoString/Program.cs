namespace BasicoString
{
    public class Program
    {
        public static void Main()
        {
            string saudacao = "     Olá Mundo!     ";
            Console.WriteLine($"[{saudacao}]");

            string apararSaudacao = saudacao.TrimStart();
            Console.WriteLine($"[{apararSaudacao}]");

            apararSaudacao = saudacao.TrimEnd();
            Console.WriteLine($"[{apararSaudacao}]");

            apararSaudacao = saudacao.Trim();
            Console.WriteLine($"[{apararSaudacao}]");

            string digaOla = "Olá Mundo!";
            Console.WriteLine(digaOla);

            digaOla = digaOla.Replace("Olá", "Koe");
            Console.WriteLine(digaOla);

            Console.WriteLine(digaOla.ToUpper());
            Console.WriteLine(digaOla.ToLower());
        }
    }
}