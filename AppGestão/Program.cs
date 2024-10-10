
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
        for (int i = 0; i < repositorioTarefa.Tarefas().Count; i++)
        {
            Tarefa tarefa = repositorioTarefa.Tarefas()[i];
            Console.WriteLine(tarefa);
    
        }
    }
    else if(opcaoDoUsuario == "3"){
             Console.WriteLine(status);   
    }
    else if(opcaoDoUsuario == "0"){
        break;
    }

}
