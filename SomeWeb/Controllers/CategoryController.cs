using Microsoft.AspNetCore.Mvc;
using SomeWeb.Data;

namespace SomeWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDBContext _db;
    public CategoryController(ApplicationDBContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        //var objCategoryList = _db.Categories.ToList();
        return View();
    }
}