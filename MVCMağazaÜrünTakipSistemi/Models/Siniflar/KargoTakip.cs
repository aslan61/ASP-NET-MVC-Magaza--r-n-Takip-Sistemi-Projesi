using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public String TakipKodu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public String Açiklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}