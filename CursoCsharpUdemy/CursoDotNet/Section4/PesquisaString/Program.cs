namespace PesquisaString
{
    public class Program
    {
        public static void Main()
        {
            string letraMusica = "Você disse tchau, e eu digo olá";
            Console.WriteLine(letraMusica.Contains("tchau"));
            Console.WriteLine(letraMusica.Contains("saudações"));

            Console.WriteLine(letraMusica.StartsWith("Você"));
            Console.WriteLine(letraMusica.StartsWith("tchau"));
        }
    }
}