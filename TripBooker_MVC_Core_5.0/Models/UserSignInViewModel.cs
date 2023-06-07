using System.ComponentModel.DataAnnotations;

namespace TripBooker_MVC_Core_5._0.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Giriniz.")]
        public string password { get; set; }
    }
}
