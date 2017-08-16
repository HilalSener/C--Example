using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.DAL.Core
{
    public class AltKategori
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string altkategoriad { get; set; }

        //public int kategoriid { get; set; }
        public string aciklama { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        //[ForeignKey("kategoriid")]
        [Required]
        public virtual Kategori Kategori { get; set; }
        public virtual List<Urun> Urunler { get; set; }

    }
}
