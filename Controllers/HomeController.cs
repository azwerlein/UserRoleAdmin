using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserRoleAdmin.Models;

namespace UserRoleAdmin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private UserManager<AppUser> userManager;

    public HomeController(ILogger<HomeController> logger, UserManager<AppUser> usrMgr)
    {
        _logger = logger;
        userManager = usrMgr;
    }

    public ViewResult Index() => View(userManager.Users);

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
