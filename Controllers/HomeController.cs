using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using conectionMysql.Models;


namespace conectionMysql.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {   
        return View();
    }
    [HttpGet]
    [Route("/listar")]
    public IActionResult Listar()
    {   
        Console.Write("entre al get ");
         List<Mascota> ListaMascota = new List<Mascota>();    
        ListaMascota = _context.Mascotas.ToList(); 
        return View("Privacy",ListaMascota);
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
