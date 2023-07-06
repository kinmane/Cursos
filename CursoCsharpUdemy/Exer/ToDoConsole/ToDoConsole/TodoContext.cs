using Microsoft.EntityFrameworkCore;

namespace ToDoConsole
{
    public class TodoContext : DbContext
    {
        public DbSet<ToDo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todo.db");
        }
    }
}