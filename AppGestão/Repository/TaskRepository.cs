using System;
using AppGestão.Modelss;

namespace AppGestão.Repository;

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
