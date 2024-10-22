
using AppGestão.IU;
using AppGestão.Modelo;
using AppGestão.Repositório;

TaskRepository taskRepository = new();

while (true) 
{
    string userOption = Menu.Exibir();

    if (userOption == "1")
    {
        Register register = new();
        Taskk task = register.RegisterTask();
        taskRepository.Register(task);
    }
    else if (userOption == "2")
    {
        List<Taskk> tasks = taskRepository.Tasks();
            if(tasks.Count == 0){
                Console.WriteLine("Nenhuma tarefa cadastrada.\n");
            }

            for (int i = 0; i < taskRepository.Tasks().Count; i++)
            {
                Taskk task = taskRepository.Tasks()[i];
                Console.WriteLine(task);
            }
    }
    else if(userOption == "0"){
        break;
    }

}
