namespace ParametrosAcessibilidadeSobrecargaOverride
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            Console.WriteLine(carro1.DigaSeunome("Palio"));
            Console.WriteLine(carro2.DigaSeunome("Fusca"));
            Console.WriteLine(carro3.DigaSeunome("Gol"));
        }
    }

    class Carro
    {
        private string nome;
        public Carro(string Nome)
        {
            nome = Nome;
        }

        public Carro()
        {

        }

        public string DigaSeunome()
        {
            return nome;
        }

        public string DigaSeunome(string Nome)
        {
            return Nome;
        }
    }
}

