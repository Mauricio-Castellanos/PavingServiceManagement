using Microsoft.AspNetCore.Mvc;
using PavingServiceManagement.Models;
namespace PavingServiceManagement.Controllers;

public class DashboardController : Controller
{
    // Public preview using fictional records, not an authenticated staff dashboard.
    public IActionResult Index() => View(new List<JobPreview>
    {
        new(1001, "Sample Customer A", "Driveway paving", "New", "Unassigned"),
        new(1002, "Sample Customer B", "Asphalt repair", "Scheduled", "Sample Employee A"),
        new(1003, "Sample Customer C", "Sealcoating", "Completed", "Sample Employee B")
    });
}
