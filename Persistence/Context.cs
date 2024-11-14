using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Persistence;

public class Context : DbContext
{
    public Context() {}
    public DbSet<Labor> Labors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlite(
                $"Data Source=../UI.ConsoleApp/TaskManager_EFCore.db"
            );
        }
    }
}
