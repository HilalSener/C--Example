using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEFCodeFirst.DataModel
{
    public class Urun
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string UrunAdi { get; set; }
        [Required]
        [DefaultValue(1)]
        public int Miktar { get; set; }
        [Required]
        [DefaultValue(0)]
        public double Fiyat { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual AltKategori AltKategori { get; set; }
    }
}