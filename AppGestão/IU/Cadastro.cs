using System;
using AppGestão.Modelo;

namespace AppGestão.IU;

public class Register
{
    public Taskk RegisterTask()
    {
        Taskk task = new();

        Console.Write("Prazo: ");
        task.Prompt = Console.ReadLine();

        Console.Write("Descrição: ");
        task.Description = Console.ReadLine();

        Console.Write("Prioridade: ");
        task.Priority = Console.ReadLine();

        Console.Write("Categoria: ");
        task.CategoryId = Console.ReadLine();

        Console.Write("Status: ");
        task.Status = Console.ReadLine();

        return task;
    }
}
