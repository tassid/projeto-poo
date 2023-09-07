using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProCRM.Models;

namespace ProCRM.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        HomeModel home = new HomeModel();
        {
            home.Nome = "Tassiane";
            home.Email = "tassianeanzolin@gmail.com";
        };

        return View(home);
    }

    public IActionResult Privacy( )
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

