using System;

namespace AppGestão.Modelo;

public class Taskk
{
    public int Id {get;set;}
    public string Prompt { get; set; }

    public string Description { get; set; }

    public string Priority { get; set; }

    public string CategoryId { get; set; }

    public string Status { get; set; }

    public override string ToString()
    {
        return $"[{Prompt}, {Description}, {Priority}, {Status}]";
    }
}
 