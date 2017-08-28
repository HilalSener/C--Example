using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.DataModel
{
    [Table("Etiketler")]
    public class Etiket
    {
        public int EtiketID { get; set; }

        [Required(ErrorMessage = "Lütfen etiket içeriğini giriniz!")]
        [StringLength(20, ErrorMessage = "Etiket 20 karakterden uzun olmamalıdır.")]
        public string Icerik { get; set; }

        //Relations

        //Bir etiket çok sayıda makalede kullanılabilir
        public virtual List<Makale> Makaleler { get; set; }
    }
}
