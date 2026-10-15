using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PavingServiceManagement.Models;
using PavingServiceManagement.Services;
namespace PavingServiceManagement.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(ServiceCatalog.All);
    public IActionResult Services() => View(ServiceCatalog.All);
    public IActionResult ProjectPlan() => View();
    public IActionResult Privacy() => View();
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
