namespace ToDoConsole
{
    public class ToDoList
    {
        private List<ToDo> tasks;
        private TodoContext dbContext;

        public ToDoList()
        {
            dbContext = new TodoContext();
            tasks = dbContext.Todos.ToList();
        }

        public void AddTask(string description)
        {
            ToDo task = new ToDo { Description = description };
            tasks.Add(task);
            dbContext.Todos.Add(task);
            dbContext.SaveChanges();
            Console.WriteLine("Nova tarefa adicionada com sucesso!");
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                ToDo task = tasks[index];
                tasks.RemoveAt(index);
                dbContext.Todos.Remove(task);
                dbContext.SaveChanges();
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        public void EditTask(int index, string newDescription)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].Description = newDescription;
                dbContext.SaveChanges();
                Console.WriteLine("Tarefa editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }

        public void PrintAllTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("A lista de tarefas está vazia.");
            }
            else
            {
                Console.WriteLine("Lista de Tarefas:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"[{i}] - Descrição: {tasks[i].Description}, Completa: {tasks[i].IsComplete}, Data de Criação: {tasks[i].CreatedDate}");
                }
            }
        }
    }
}