using System.ComponentModel.DataAnnotations;

namespace SolutionName.Web.Models.User;
public class ForgotPasswordViewModel
{
    [Required]
    public string Email { get; set; }
    
}
