﻿using System.ComponentModel.DataAnnotations;

namespace TripBooker_MVC_Core_5._0.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı giriniz.")]

		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]

		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]

		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]

		public string EMail { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]

		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz.")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")]

		public string ComfirmPassword { get; set; }
	}
}
