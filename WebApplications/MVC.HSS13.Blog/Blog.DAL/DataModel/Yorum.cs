using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.DataModel
{
    [Table("Yorumlar")]
    public class Yorum
    {
        public int YorumID { get; set; }

        [Required(ErrorMessage = "Lütfen yorum içeriğini giriniz!")]
        public string Icerik { get; set; }

        public int? UyeID { get; set; }

        public int MakaleID { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Relations
        //Her yorum bir üyeye aittir
        public virtual Uye Uye { get; set; }
        //Her yorum bir makale hakkındadır
        public virtual Makale Makale { get; set; }
    }
}
