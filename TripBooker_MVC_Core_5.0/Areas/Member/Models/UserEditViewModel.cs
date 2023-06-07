using Microsoft.AspNetCore.Http;

namespace TripBooker_MVC_Core_5._0.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string name { get; set; }

        public string surname { get; set; }

        public string password { get; set; }

        public string confirmpasword { get; set; }

        public string phonenumber { get; set; }

        public string mail { get; set; }

        public string imgurl { get; set; }

        public IFormFile image { get; set; }
    }
}
