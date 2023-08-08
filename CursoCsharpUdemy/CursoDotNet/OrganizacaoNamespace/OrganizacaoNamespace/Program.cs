namespace OrganizacaoNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Carro carro = new Carro();
            carro.DigaSeuNome();
            
            Aviao aviao = new Aviao();
            aviao.DigaSeuNome();
            
            MeusTestes.Carro carro2 = new MeusTestes.Carro();
            carro2.DigaSeuNome();
            
        }
    }
    
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Meu nome é carro");
        }
    }
}

namespace MeusTestes
{
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Meu nome é carro");
        }
    }
}

class Aviao
     {
         public void DigaSeuNome()
         {
             Console.WriteLine("Meu nome é avião");
         }
     }