using PavingServiceManagement.Models;
namespace PavingServiceManagement.Services;

// Read-only sample catalog. Replace with a database-backed service in a later section.
public static class ServiceCatalog
{
    public static IReadOnlyList<ServiceOption> All { get; } = Array.AsReadOnly(new[]
    {
        new ServiceOption("Driveway paving", "A clear path to a new driveway.", "Request an evaluation for a new asphalt driveway or replacement of an existing surface."),
        new ServiceOption("Asphalt repair", "Take care of worn and damaged areas.", "Describe potholes, cracks, or uneven areas so the team can review the repair needs."),
        new ServiceOption("Sealcoating", "Plan routine surface maintenance.", "Request a review of your existing asphalt surface and its maintenance needs.")
    });
}
