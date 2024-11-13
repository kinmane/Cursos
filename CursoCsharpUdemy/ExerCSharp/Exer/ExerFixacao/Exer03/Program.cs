namespace Exer03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno student = new Aluno();
            
            System.Console.Write("Nome do student: ");
            student.Name = System.Console.ReadLine();
            
            System.Console.WriteLine("Digite as três notas do aluno:");
            student.Grade1 = double.Parse(System.Console.ReadLine());
            student.Grade2 = double.Parse(System.Console.ReadLine());
            student.Grade3 = double.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine("NOTA FINAL = " + student.FinalGrade().ToString("F2"));
            
            if (student.Approved())
            {
                System.Console.WriteLine("APROVADO");
            }
            else
            {
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM " + student.MissingPoints().ToString("F2") + " PONTOS");
            }
        }
    }
}