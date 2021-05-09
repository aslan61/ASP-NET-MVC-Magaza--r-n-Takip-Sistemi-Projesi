using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Adminid{ get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public String KullaniciAd{ get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String Sifre { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1)]
        public String Yetki { get; set; }
    }
}