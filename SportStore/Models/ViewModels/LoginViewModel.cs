using System.ComponentModel.DataAnnotations;

namespace SportStore.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required] 
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}