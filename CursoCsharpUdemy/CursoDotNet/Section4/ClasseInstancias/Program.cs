namespace ClasseInstancias
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Bolo
            //instanciando
            Carro carro1 = new Carro();
            carro1.Nome = "Palio";
            Carro carro2 = new Carro();
            carro2.Nome = "Gol";
            Carro carro3 = new Carro();
            carro3.Nome = "Fusca";

            Console.WriteLine(carro1.DigaSeunome());
            Console.WriteLine(carro2.DigaSeunome());
            Console.WriteLine(carro3.DigaSeunome());
        }
    }

    //FORMA
    class Carro
    {
        public string Nome { get; set; }

        public string DigaSeunome()
        {
            return Nome;
        }
    }
}