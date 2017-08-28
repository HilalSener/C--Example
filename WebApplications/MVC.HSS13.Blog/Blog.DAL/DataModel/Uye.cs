using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.DataModel
{
    [Table("Uyeler")]
    public class Uye
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

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Relations

        //Bir üye çok sayıda makale oluşturabilir.
        public virtual List<Makale> Makaleler { get; set; }

        //Bir üye çok sayıda yorum yazabilir.
        public virtual List<Yorum> Yorumlar { get; set; }

    }
}
