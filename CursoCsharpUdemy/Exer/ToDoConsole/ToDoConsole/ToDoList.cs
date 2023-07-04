namespace ToDoConsole
{
    public class ToDoList
    {
        private List<ToDo> _tasks;

        public ToDoList()
        {
            _tasks = new List<ToDo>();
        }

        public void AddTask(string description)
        {
            ToDo task = new ToDo {Description = description};
            _tasks.Add(task);
            Console.WriteLine("Nova tarefa adicionada com sucesso!");
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < _tasks.Count)
            {
                _tasks.RemoveAt(index);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
        
        public void EditTask(int index, string description)
        {
            if (index >= 0 && index < _tasks.Count)
            {
                _tasks[index].Description = description;
                Console.WriteLine("Tarefa editada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }

        public void PrintAllTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada!");
            }
            else
            {
                Console.WriteLine("Tarefas cadastradas:");
                for (int i = 0; i < _tasks.Count; i++)
                {
                    Console.WriteLine($"{i} - {_tasks[i].Description}");
                }
            }
        }
    }
}