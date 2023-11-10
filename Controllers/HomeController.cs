using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefNDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ChefsNDishesContext _context;

    public HomeController(ILogger<HomeController> logger, ChefsNDishesContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Chef> AllChefs = _context.Chefs.Include(chef => chef.CreatedDishes).ToList();
        return View(AllChefs);
    }

    [HttpGet("chefs/new")]
    public IActionResult AddChef()
    {
        return View();
    }

    [HttpPost("chefs/new")]
    public IActionResult AddChef(Chef newChef)
    {
        if (ModelState.IsValid)
        {
            _context.Chefs.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("AddChef");
        }
    }

    [HttpGet("dishes/new")]
    public IActionResult AddDish()
    {
        List<Chef> AllChefs = _context.Chefs.Include(chef => chef.CreatedDishes).ToList();
        ViewBag.AllChefs = AllChefs;
        return View();
    }

    [HttpPost("dishes/new")]
    public IActionResult ProcessDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine($"********** {newDish.ChefId} ********** valid");
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        Console.WriteLine($"********** {newDish.ChefId} ********** not valid");
        return RedirectToAction("AddDish");

    }

    [HttpGet("dishes")]
    public IActionResult Dishes()
    {
        List<Dish> AllDishes = _context.Dishes.Include(dish => dish.Creator).ToList();
        return View(AllDishes);
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
