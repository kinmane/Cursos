namespace Exer02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            System.Console.Write("Nome do primeiro funcionário: ");
            f1.Name = System.Console.ReadLine();
            System.Console.Write("Salário do primeiro funcionário: ");
            f1.Salary = double.Parse(System.Console.ReadLine());

            System.Console.Write("Nome do segundo funcionário: ");
            f2.Name = System.Console.ReadLine();
            System.Console.Write("Salário do segundo funcionário: ");
            f2.Salary = double.Parse(System.Console.ReadLine());

            double average = (f1.Salary + f2.Salary) / 2;

            System.Console.WriteLine($"Salário médio = {average}");
        }
    }
}