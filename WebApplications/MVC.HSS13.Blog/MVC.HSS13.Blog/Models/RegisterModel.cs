using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.HSS13.Blog.Models
{
    public class RegisterModel
    {
        public int UyeID { get; set; }

        [Required(ErrorMessage = "Lütfen üye adını giriniz!")]
        [StringLength(20, ErrorMessage = "İsim 20 karakterden uzun olmamalıdır.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen üye soyadını giriniz!")]
        [StringLength(20, ErrorMessage = "Soyisim 20 karakterden uzun olmamalıdır.")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi giriniz.")]
        [EmailAddress(ErrorMessage = "Email formatına uygun giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Compare("Sifre", ErrorMessage = "Şifreler aynı değil!")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        public string SifreTekrar { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }
    }
}