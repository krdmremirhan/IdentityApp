using System.ComponentModel.DataAnnotations;

namespace İdentityAp.ViewModels;

public class LoginViewModel
{
    [Required]
     [EmailAddress]
    // public string Email { get; set; }
    public string Email { get; set; }

    public string UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Display(Name = "Remember me")]
    public bool RememberMe { get; set; }

    public string? ReturnUrl { get; set; }



}