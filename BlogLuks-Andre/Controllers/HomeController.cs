using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogLuks_Andre.Models;

namespace BlogLuks_Andre.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Postagem> postagens;
    private List<Categoria> categorias;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    categorias = new List<Categoria>
        {
            new(1, "Nem Vilões nem Heróis."),
            new(2, "Gon, Killua, Kurapika e Leorio."),
            new(3, "Vilão é só um ponto de vista?"),
            new(4, "Nen, Ten, Ren, Zetsu e Hatsu."),
            new(5, "Trupe Fantasma, Formigas Chimera e mais."),
            new(6, "Reino Sombrio, Greed Island e muito mais.")
        };

        postagens = [
            new (){
                Id = 1,
                Nome = "Nem Vilões nem Heróis.",
                Papel = "Antagonistas",
                CategoriaId = 1,
                Categoria = categorias.First(c => c.Id == 1),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Em Hunter x Hunter, ninguém é totalmente bom ou mau; cada personagem age por motivos próprios, tornando heróis e vilões apenas rótulos ilusórios.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/1.jpg",
                Foto = "/img/1.jpg"
            },

            new (){
                Id = 2,
                Nome = "Gon, Killua, Kurapika e Leorio.",
                Papel = "Protagonistas",
                CategoriaId = 2,
                Categoria = categorias.First(c => c.Id == 2),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Os protagonistas de HxH não são perfeitos; eles crescem, cometem erros e enfrentam dilemas, mostrando coragem, amizade e determinação em um mundo complexo.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/2.jpg",
                Foto = "/img/2.jpg"
            },

            new (){
                Id = 3,
                Nome = "Vilão é só um ponto de vista?",
                Papel = "Vilões",
                CategoriaId = 3,
                Categoria = categorias.First(c => c.Id == 3),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Em HxH, vilão é só um ponto de vista, pois moralidade depende do olhar de quem observa.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/3.jpg",
                Foto = "/img/3.jpg"
            },
            new (){
                Id = 4,
                Nome = "Nen, Ten, Ren, Zetsu e Hatsu.",
                Papel = "Poderes",
                CategoriaId = 4,
                Categoria = categorias.First(c => c.Id == 4),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Nen é a energia vital; Ten protege, Zetsu oculta, Ren fortalece, e Hatsu é o poder único de cada um.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/4.jpg",
                Foto = "/img/4.jpg"
            },
            new (){
                Id = 5,
                Nome = "Trupe Fantasma, Formigas Chimera e mais.",
                Papel = "Sociedades",
                CategoriaId = 5,
                Categoria = categorias.First(c => c.Id == 5),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "HxH apresenta sociedades complexas: Trupe Fantasma, Formigas Quimera e outras, mostrando que força, moral e objetivos podem coexistir fora da linha simples de herói vs vilão.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/5.jpg",
                Foto = "/img/5.jpg"
            },

            new (){
                Id = 6,
                Nome = "Reino Sombrio, Greed Island e muito mais.",
                Papel = "Curiosidades",
                CategoriaId = 6,
                Categoria = categorias.First(c => c.Id == 6),
                DataPostagem = DateTime.Parse("07/08/2025"),
                Descricao = "Hunter x Hunter explora mundos únicos como Reino Sombrio e Greed Island, cada um repleto de perigos, desafios e oportunidades de crescimento.",
                Texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Thumbnail = "/img/6.jpg",
                Foto = "/img/6.jpg"
            }
        ]; 
    }

    public IActionResult Index()
    {
        
        return View(postagens);
    }

    public IActionResult Postagem(int id)
    {
        var postagem = postagens
            .Where(p => p.Id == id)
            .SingleOrDefault();
        if(postagem == null)
            return NotFound();
        return View(postagem);
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
