using Projeto_Web_Lh_Pets_versão_1;

namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        var db = new Banco();

        app.MapGet("/", () => "Projeto Web - Projeto LH Pets!");

        app.UseStaticFiles();

        app.MapGet("/index", (HttpContext context) => {
            context.Response.Redirect("index.html", false);
        });

        app.MapGet("/listaClientes", (HttpContext context) => {
            context.Response.WriteAsync(db.GetListaString());
        });

        app.Run();
    }
}
