using System;

namespace AppGestão.Modelo;

public class Tarefa
{
    public int Id {get;set;}
    public string Prazo { get; set; }

    public string Descricao { get; set; }

    public string Prioridade { get; set; }

    public string CodCategoria { get; set; }

    public string Status { get; set; }

    public override string ToString()
    {
        return $"[{Prazo}, {Descricao}, {Prioridade}, {Status}]";
    }
}
