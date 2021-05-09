using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCMağazaÜrünTakipSistemi.Models.Siniflar
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        [Display(Name = "Fatura Seri No")]
        public String FaturaSeriNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        [Display(Name = "Fatura Sıra No")]
        public String FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public String VergiDairesi { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        public String Saat { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Display(Name = "Teslim Eden")]
        public String TeslimEden { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Display(Name = "Teslim Alan")]
        public String TeslimAlan { get; set; }

        public decimal Toplam { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }

    }
}