using System.ComponentModel.DataAnnotations;

namespace İdentityAp.ViewModels;

public class ExternalLoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]

    public string Name { get; set; }
    
}