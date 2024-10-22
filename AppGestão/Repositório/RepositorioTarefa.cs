using System;
using AppGestão.Modelo;

namespace AppGestão.Repositório;

public class TaskRepository
{
    private List<Taskk> tasks = [];

    public void Register(Taskk task){
        tasks.Add(task);
    }

    public List<Taskk> Tasks(){
        return tasks;
    }
}
