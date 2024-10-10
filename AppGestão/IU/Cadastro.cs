using System;
using AppGestão.Modelo;

namespace AppGestão.IU;

public class Cadastro
{
    public Tarefa CadastrarTarefa()
    {
        Tarefa tarefa = new();

        Console.Write("Prazo: ");
        tarefa.Prazo = Console.ReadLine();

        Console.Write("Descrição: ");
        tarefa.Descricao = Console.ReadLine();

        Console.Write("Prioridade: ");
        tarefa.Prioridade = Console.ReadLine();

        Console.Write("Categoria: ");
        tarefa.Categoria = Console.ReadLine();

        Console.Write("Status: ");
        tarefa.Status = Console.ReadLine();

        return tarefa;
    }
}
