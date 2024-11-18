using Models;
using Persistence;

internal class Program
{
    private static void Main(string[] args)
    {
        var labor = new Labor(
            "Teste","Testando EFCore",DateTime.Now.Date, DateTime.Parse("18/11/2024"),"urgente","estudo",false
        );

        var context = new Context();
        context.Add(labor);
        context.SaveChanges();
    }
}