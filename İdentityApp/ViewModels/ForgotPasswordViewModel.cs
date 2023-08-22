using System.ComponentModel.DataAnnotations;

namespace İdentityAp.ViewModels;

public class ForgotPasswordViewModel
{
    [Required] 
    [EmailAddress]
    public string Email { get; set; }

}