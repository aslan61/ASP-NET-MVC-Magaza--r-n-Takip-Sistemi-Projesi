using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        [Display(Name = "Kategoriler")]
        public int KategoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Display(Name = "Kategori Adı")]
        public String KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}