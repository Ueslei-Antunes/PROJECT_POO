using System;
using Microsoft.EntityFrameworkCore;
using Task = Models.Task;

namespace Persistence;

public class Context : DbContext
{
    public Context() {}
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlite(
                $"Data Source=../UI.ConsoleApp/TaskManager_EFCore.db"
            );
        }
    }
}
