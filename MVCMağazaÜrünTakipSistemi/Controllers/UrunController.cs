﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMağazaÜrünTakipSistemi.Models.Siniflar;

namespace MVCMağazaÜrünTakipSistemi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index(string p)
        {
            var urunler = from x in c.Uruns select x;
            if (!string.IsNullOrEmpty(p))
            {
                urunler = urunler.Where(y => y.UrunAd.Contains(p));
            }     
            return View(urunler.ToList());
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList() select new SelectListItem
            {
                Text=x.KategoriAd,
                Value=x.KategoriID.ToString()
            }).ToList();
            ViewBag.dgr1 = deger1;//Controller kısmından view kısmına deger taşıdık viewbag metodu ile
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun k)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                k.UrunGorsel = "/Image/" + dosyaadi + uzanti;
            }
            c.Uruns.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            c.Uruns.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            var urundeger = c.Uruns.Find(id);
            return View("UrunGetir", urundeger);
        }
        public ActionResult UrunGuncelle(Urun p)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                p.UrunGorsel = "/Image/" + dosyaadi + uzanti;
            }
            var urn = c.Uruns.Find(p.Urunid);
            urn.AlisFiyat = p.AlisFiyat;
            urn.Durum = p.Durum;
            urn.kategoriid = p.kategoriid;
            urn.Marka = p.Marka;
            urn.SatisFiyat = p.SatisFiyat;
            urn.Stok = p.Stok;
            urn.UrunGorsel = p.UrunGorsel;
            urn.UrunAd = p.UrunAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunListesi()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult SatisYap(int id)
        {
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd + " " + x.PersonelSoyad,
                                               Value = x.Personelid.ToString()
                                           }).ToList();
            ViewBag.dgr3 = deger3;
            var deger1 = c.Uruns.Find(id);
            ViewBag.dgr1 = deger1.Urunid;
            ViewBag.dgr2 = deger1.SatisFiyat;
            return View();
        }
        [HttpPost]
        public ActionResult SatisYap(SatisHareket p)
        {
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SatisHarekets.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index","Satis");
        }
    }
}