using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaret.DAL.Core
{
    public class Satis
    {
        [Key]
        public int satisid { get; set; }
        [Required]
        public DateTime tarih { get; set; }
        public int miktar { get; set; }
        public decimal tutar { get; set; }
        public DateTime teslimtarihi { get; set; }
        public byte durumu { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        public virtual List<SatisDetay> SatisDetaylari { get; set; }
        [Required]
        public virtual Kullanici Kullanici { get; set; }
    }
}
