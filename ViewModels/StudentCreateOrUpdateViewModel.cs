using System.ComponentModel.DataAnnotations;

namespace mvc.ViewModels;

public class StudentCreateOrUpdateViewModel
{
    [Required]
    public string? FulName { get; set; }
    public string? PhoneNumber { get; set; }
    public ulong GroupId { get; set; }
}