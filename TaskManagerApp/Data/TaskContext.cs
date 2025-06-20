using Microsoft.EntityFrameworkCore;

namespace TaskManagerApp.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<TaskManagerApp.Models.Task> Tasks { get; set; }
    }
}