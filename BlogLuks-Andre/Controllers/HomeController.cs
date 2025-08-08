using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogLuks_Andre.Models;

namespace BlogLuks_Andre.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Olá Mundo!";
        //Criar objetos
        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Tecnologia";

        Categoria categoria2 = new() 
        {
            Id= 2,
            Nome = "IA"
        };

        List<Postagem> postagens = [
            new (){
                Id = 1,
                Nome = "Saiu o CHATGPT 5!!!",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Estou com preguiça de pensar nisso",
                Texto = "Lorem ipsum"
            }
        ] 

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
