using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_02___Recetiify.Models;

namespace TP_02___Recetiify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    public IActionResult GenerarReceta (Receta receta)
    {
        ViewBag.nombre = receta.Nombre;
        ViewBag.edad = receta.CalcularEdad();
        ViewBag.plato = receta.determinarPlato();
        ViewBag.tiempo = receta.calcularTiempo();
        ViewBag.personas = receta.CantPersonas;
        ViewBag.dificultad = receta.determinarDificultad();
        
        return View("Resultado");
    }
}
