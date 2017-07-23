using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEFCodeFirst.DataModel
{
    public class AltKategori
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string AltKategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual List<Urun> Urunler { get; set; }
    }
}