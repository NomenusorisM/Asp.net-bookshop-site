using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNET.Models;

namespace ASPNET.Controllers;
public class AccountController : Controller
{ 
    public IActionResult Login() => View();
    public IActionResult Registration() => View();
    public IActionResult Profile() => View();
        
}
