using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripBooker_MVC_Core_5._0.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
