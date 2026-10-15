using System.ComponentModel.DataAnnotations;
namespace PavingServiceManagement.Models;

// Part II input model. Database persistence is a later milestone.
public class ServiceRequestInput
{
    [Required, StringLength(100), Display(Name = "Full name")]
    public string FullName { get; set; } = string.Empty;
    [Required, EmailAddress, StringLength(254), Display(Name = "Email address")]
    public string Email { get; set; } = string.Empty;
    [Required, Phone, StringLength(30), Display(Name = "Phone number")]
    public string Phone { get; set; } = string.Empty;
    [Required, StringLength(250), Display(Name = "Property address")]
    public string PropertyAddress { get; set; } = string.Empty;
    [Required, Display(Name = "Requested service")]
    public string ServiceType { get; set; } = string.Empty;
    [StringLength(1000), Display(Name = "Project details")]
    public string? Description { get; set; }
}
