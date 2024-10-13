using System;

namespace AppGestão.Modelo;

public class Tarefa
{
    public string Prazo { get; set; }

    public string Descricao { get; set; }

    public string Prioridade { get; set; }

    public string Categoria { get; set; }

    public string Status { get; set; }

    public override string ToString()
    {
        return $"[{ Prazo },{ Descricao }, { Prioridade },{ Categoria },{ Status }]";
    }
}
