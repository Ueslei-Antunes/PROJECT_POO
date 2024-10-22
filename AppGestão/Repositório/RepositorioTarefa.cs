using System;
using AppGestão.Modelo;

namespace AppGestão.Repositório;

public class RepositorioTarefa
{
    private List<Taskk> tarefas = [];

    public void Cadastrar(Taskk tarefa){
        tarefas.Add(tarefa);
    }

    public List<Taskk> Tarefas(){
        return tarefas;
    }
}
