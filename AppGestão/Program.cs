
using AppGestão.IU;
using AppGestão.Modelo;
using AppGestão.Repositório;

RepositorioTarefa repositorioTarefa = new();

while (true)
{
    string Useroption = Menu.Exibir();

    if (Useroption == "1")
    {
        Register cadastro = new();
        Taskk tarefa = cadastro.RegisterTask();
        repositorioTarefa.Cadastrar(tarefa);
    }
    else if (Useroption == "2")
    {
        List<Taskk> tarefas = repositorioTarefa.Tarefas();
            if(tarefas.Count == 0){
                Console.WriteLine("Nenhuma tarefa cadastrada.\n");
            }

            for (int i = 0; i < repositorioTarefa.Tarefas().Count; i++)
            {
                Taskk tarefa = repositorioTarefa.Tarefas()[i];
                Console.WriteLine(tarefa);
            }
    }
    else if(Useroption == "3"){

        List<Taskk> tarefas = repositorioTarefa.Tarefas();

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.\n"); //exemplo commit
        }
        else
        {
            Console.WriteLine("Status das Tarefas:"); //comit exemplare
            foreach (Taskk tarefa in tarefas)
            {
                Console.WriteLine($"Status: {tarefa.Status}");
            }
            Console.WriteLine();
        }
    }
    else if(Useroption == "0"){
        break;
    }

}
