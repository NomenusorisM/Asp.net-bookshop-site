using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using Microsoft.AspNetCore.Identity;
using BookShop.Db;
using Microsoft.AspNetCore.Authorization;

namespace BookShop.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ApplicationContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_context.Books.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult About() => View();
    public IActionResult Contact() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult AddBook()
    {
        if (User.Identity.IsAuthenticated)
            return View();
        else throw new Exception();
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(Book book)
    {
        // Заглушка, в дальнейшем будет реализован выбор
        book.AuthorId = 1;
        book.Year = 0;
        book.CategoryId = 1;
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index", "Home");
    }
}
