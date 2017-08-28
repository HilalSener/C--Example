using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.DataModel
{
    [Table("Makaleler")]
    public class Makale
    {
        public int MakaleID { get; set; }

        [Required(ErrorMessage = "Lütfen makale başlığını giriniz!")]
        [StringLength(50, ErrorMessage = "Başlık 50 karakterden uzun olmamalıdır.")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Lütfen makale içeriğini giriniz!")]
        [DataType(DataType.Html)]
        public string Icerik { get; set; }

        public int? UyeID { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Relations
        //Her makale bir üyeye aittir
        public virtual Uye Uye { get; set; }

        //Bir makale hakkında çok sayıda yorum yapılabilir
        public virtual List<Yorum> Yorumlar { get; set; }

        //Bir makalede çok sayıda etiket kullanılabilir 
        public virtual List<Etiket> Etiketler { get; set; }
    }
}
