
using AppGestão.IU;
using AppGestão.Modelo;
using AppGestão.Repositório;

RepositorioTarefa repositorioTarefa = new();

while (true)
{
    string opcaoDoUsuario = Menu.Exibir();

    if (opcaoDoUsuario == "1")
    {
        Cadastro cadastro = new();
        Tarefa tarefa = cadastro.CadastrarTarefa();
        repositorioTarefa.Cadastrar(tarefa);
    }
    else if (opcaoDoUsuario == "2")
    {
        List<Tarefa> tarefas = repositorioTarefa.Tarefas();
            if(tarefas.Count == 0){
                Console.WriteLine("Nenhuma tarefa cadastrada.\n");
            }

            for (int i = 0; i < repositorioTarefa.Tarefas().Count; i++)
            {
                Tarefa tarefa = repositorioTarefa.Tarefas()[i];
                Console.WriteLine(tarefa);
            }
    }
    else if(opcaoDoUsuario == "3"){

        List<Tarefa> tarefas = repositorioTarefa.Tarefas();

        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.\n"); //exemplo commit
        }
        else
        {
            Console.WriteLine("Status das Tarefas:"); //comit exemplare
            foreach (Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Status: {tarefa.Status}");
            }
            Console.WriteLine();
        }
    }
    else if(opcaoDoUsuario == "0"){
        break;
    }

}
