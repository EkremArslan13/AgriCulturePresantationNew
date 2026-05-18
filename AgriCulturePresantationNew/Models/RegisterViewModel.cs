using System.ComponentModel.DataAnnotations;

namespace AgriCulturePresantationNew.Models

{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı adını giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen mail giriniz")]
        public string mail { get; set; }

        [Required(ErrorMessage ="Lütfen şifre giriniz")]
        public string password { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi tekrar giriniz")]
        [Compare("password",ErrorMessage ="Şifreler uyumlu değil,kontrol ediniz")]
        public string paswordconfirm { get; set; }



    }
}
