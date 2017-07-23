using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEFCodeFirst.DataModel
{
    public class Kategori
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }

        public virtual List<AltKategori> AltKategoriler { get; set; }

        public virtual List<Urun> Urunler { get; set; }
    }
}