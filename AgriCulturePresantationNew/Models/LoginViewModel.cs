using System.ComponentModel.DataAnnotations;

namespace AgriCulturePresantationNew.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz")]

        public string? UserName { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]

        public string? Password { get; set; }
      
    }
}
