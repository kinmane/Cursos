namespace ToDoConsole
{
    public class ToDo
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime Date { get; set; }
        
        public ToDo()
        {
            Date = DateTime.Now;
        }
    }
}
