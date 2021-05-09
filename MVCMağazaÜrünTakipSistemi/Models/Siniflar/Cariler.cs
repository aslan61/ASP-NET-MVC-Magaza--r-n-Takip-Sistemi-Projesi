using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30,ErrorMessage="En Fazla 30 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        [Display(Name = "Cari Adı")]
        public String CariAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En Fazla 30 karakter yazabilirsiniz")]
        [Required (ErrorMessage ="Bu Alanı Boş Geçemezsiniz!")]
        [Display(Name = "Cari Soyadı")]
        public String CariSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13,ErrorMessage = "En Fazla 13 karakter yazabilirsiniz")]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz!")]
        [Display(Name = "Cari Şehri")]
        public String CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En Fazla 50 karakter yazabilirsiniz")]
        [Display(Name = "Cari Maili")]
        public String CariMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En Fazla 20 karakter yazabilirsiniz")]
        public String CariSifre { get; set; }

        public bool durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}