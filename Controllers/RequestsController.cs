using Microsoft.AspNetCore.Mvc;
using PavingServiceManagement.Models;
using PavingServiceManagement.Services;
namespace PavingServiceManagement.Controllers;

public class RequestsController : Controller
{
    [HttpGet]
    public IActionResult Create() => View(new ServiceRequestInput());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ServiceRequestInput input)
    {
        if (!string.IsNullOrWhiteSpace(input.ServiceType) &&
            !ServiceCatalog.All.Any(service => service.Name == input.ServiceType))
            ModelState.AddModelError(nameof(input.ServiceType), "Select a listed service.");

        if (!ModelState.IsValid) return View(input);

        // Demonstrates model binding and validation; no data is persisted or sent.
        TempData["PrototypeMessage"] = "The sample form passed validation. This Part II prototype does not save or send requests.";
        return RedirectToAction(nameof(Create));
    }
}
