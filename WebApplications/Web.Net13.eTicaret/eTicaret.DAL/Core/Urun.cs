using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.DAL.Core
{
    public class Urun
    {
        [Key]
        public int urunid { get; set; }
        [Required]
        [MaxLength(20)]
        public string urunkodu { get; set; }
        [Required]
        [MaxLength(50)]
        public string urunad { get; set; }
        [Required]
        [DefaultValue(1)]
        public int miktar { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal urunfiyat { get; set; }
        [MaxLength(100)]
        public string urunresimyolu1 { get; set; }
        [MaxLength(100)]
        public string urunresimyolu2 { get; set; }

        public string urunbilgisi { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual AltKategori AltKategori { get; set; }
        public virtual List<SatisDetay> SatisDetaylari { get; set; }
    }
}
