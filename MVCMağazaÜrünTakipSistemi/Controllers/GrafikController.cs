using MVCMağazaÜrünTakipSistemi.Models.Siniflar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVCMağazaÜrünTakipSistemi.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            var grafikciz = new Chart(600, 600);
            grafikciz.AddTitle("Kategori - Ürün Stok Sayısı").AddLegend("Stok").AddSeries
                ("Değerler", xValue: new[] { "Mobilya", "Ofis Eşyaları", "Bilgisayar"},yValues: new[] {85,66,98}).Write();
            return File(grafikciz.ToWebImage().GetBytes(), "image/jpeg");
        }
        Context c = new Context();
        public ActionResult Index3()
        {
            ArrayList xvalue = new ArrayList();
            ArrayList yvalue = new ArrayList();
            var sonuclar = c.Uruns.ToList();
            sonuclar.ToList().ForEach(x => xvalue.Add(x.UrunAd));
            sonuclar.ToList().ForEach(y => yvalue.Add(y.Stok));
            var grafik = new Chart(width: 800, height: 800).AddTitle("Stoklar").AddSeries(chartType: "Pie", name: "Stok", xValue: xvalue, yValues: yvalue);
            return File(grafik.ToWebImage().GetBytes(), "image/jpeg");
        }
        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult Visualizeurunresult()
        {
            return Json(urunlistesi(), JsonRequestBehavior.AllowGet);
        }
        public List<sinif1> urunlistesi()
        {
            List<sinif1> snf = new List<sinif1>();
            snf.Add(new sinif1
            {
                urunad = "Bilgisayar",
                stok=120
            });
            snf.Add(new sinif1() {
                urunad = "Beyaz Eşya",
                stok = 150
            });
            return snf;
        }
        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult Visualizeurunresult2()
        {
            return Json(urunlistesi2(), JsonRequestBehavior.AllowGet);
        }
        public List<sinif2> urunlistesi2()
        {
            List<sinif2> snf = new List<sinif2>();
            snf = c.Uruns.Select(x => new sinif2 {
                urn=x.UrunAd,
                stk=x.Stok
            }).ToList();
            return snf;
        }
        public ActionResult Index6()
        {
            return View();
        }
        public ActionResult Index7()
        {
            return View();
        }

    }
}