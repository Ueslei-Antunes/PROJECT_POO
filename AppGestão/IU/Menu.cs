using System;

namespace AppGestão.IU;

public class Menu
{
    public static string Exibir(){
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("===============");
        Console.WriteLine();
        Console.WriteLine("1 - Cadastrar tarefa");
        Console.WriteLine("2 - Exibir Tarefa");
        Console.WriteLine("3 - Exibir Status");
        Console.WriteLine("3 - teste");
        Console.WriteLine("0 - Sair");

        Console.WriteLine();
        Console.Write("Qual sua opção: ");
        
        return Console.ReadLine();

    }
}
