using System;
using AppGestão.Modelo;

namespace AppGestão.Repositório;

public class RepositorioTarefa
{
    private List<Tarefa> tarefas = [];

    public void Cadastrar(Tarefa tarefa){
        tarefas.Add(tarefa);
    }

    public List<Tarefa> Tarefas(){
        return tarefas;
    }
}
