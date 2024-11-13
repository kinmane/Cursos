namespace Exer02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            System.Console.Write("Nome: ");
            f.Name = System.Console.ReadLine();
            
            System.Console.Write("Salário Bruto: ");
            f.GrossSalary = double.Parse(System.Console.ReadLine());
            
            System.Console.Write("Imposto: ");
            f.Tax = double.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine();
            System.Console.WriteLine("Funcionário: " + f);
            System.Console.WriteLine();
            
            System.Console.Write("Qual percentual aumentar o salário? ");
            double percentage = double.Parse(System.Console.ReadLine());
            f.IncreaseSalary(percentage);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + f);
        }
    }
}