using Microsoft.AspNetCore.Mvc;

namespace SomeWeb.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}