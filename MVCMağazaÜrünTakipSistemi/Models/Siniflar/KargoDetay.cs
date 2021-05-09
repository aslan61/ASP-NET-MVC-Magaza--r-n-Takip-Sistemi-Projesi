using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class KargoDetay
    {
        [Key]
        public int  KargoDetayid{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public String  Açiklama{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public String  TakipKodu{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public String  Personel{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        public String  Alici{ get; set; }
        public DateTime  Tarih{ get; set; }
    }
}