namespace ToDoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            int option = -1;

            while (option != 0)
            {
                Console.WriteLine("===== Menu de Opções =====");
                Console.WriteLine("1. Adicionar nova tarefa");
                Console.WriteLine("2. Deletar tarefa");
                Console.WriteLine("3. Editar tarefa");
                Console.WriteLine("4. Imprimir todas as tarefas");
                Console.WriteLine("0. Sair do programa");
                Console.WriteLine("===========================");

                Console.Write("Digite a opção desejada: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.Write("Digite a descrição da nova tarefa: ");
                        string description = Console.ReadLine();
                        toDoList.AddTask(description);
                        break;
                    case 2:
                        Console.Write("Digite o índice da tarefa a ser removida: ");
                        int indexToDelete = int.Parse(Console.ReadLine());
                        toDoList.DeleteTask(indexToDelete);
                        break;
                    case 3:
                        Console.Write("Digite o índice da tarefa a ser editada: ");
                        int indexToEdit = int.Parse(Console.ReadLine());
                        Console.Write("Digite a nova descrição da tarefa: ");
                        string newDescription = Console.ReadLine();
                        toDoList.EditTask(indexToEdit, newDescription);
                        break;
                    case 4:
                        toDoList.PrintAllTasks();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
