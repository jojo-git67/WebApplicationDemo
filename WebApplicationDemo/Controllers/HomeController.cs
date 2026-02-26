using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}