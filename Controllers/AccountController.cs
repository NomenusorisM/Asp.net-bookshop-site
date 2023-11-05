using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookShop.Models;

namespace BookShop.Controllers;
public class AccountController : Controller
{ 
    public IActionResult Login() => View();
    public IActionResult Registration() => View();
    public IActionResult Profile() => View();
        
}
