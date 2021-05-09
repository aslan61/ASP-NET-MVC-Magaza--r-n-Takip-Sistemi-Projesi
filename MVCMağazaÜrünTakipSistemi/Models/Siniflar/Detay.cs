using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30)]
        [Display(Name = "Ürün Adı")]
        public string urunad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public String urunbilgi { get; set; }
    }
}