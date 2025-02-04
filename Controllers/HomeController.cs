using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CategoriasMvc.Models;

namespace CategoriasMvc.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }


}
