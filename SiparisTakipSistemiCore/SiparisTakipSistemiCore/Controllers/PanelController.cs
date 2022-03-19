using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiparisTakipSistemiCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Controllers
{
    public class PanelController : Controller
    {
        Context c = new Context();

        // MÜŞTERİ İŞLEMLERİ 
        public IActionResult Index()
        {

            return View(c.Musteris.ToList());
        }
        public IActionResult MusteriGuncelle(int id)
        {
            var x = c.Musteris.Find(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult MusteriGuncelle(Musteri m)
        {
            var x = c.Musteris.Find(m.MusteriID);
            x.MusteriAd = m.MusteriAd;
            x.MusteriTelefon = m.MusteriTelefon;
            x.MusteriEmail = m.MusteriEmail;
            x.MusteriParola = m.MusteriParola;
            c.SaveChanges();
            ViewBag.guncel = "Müşteri Başarıyla Güncellendi.";
            return RedirectToAction("Index");
        }

        public IActionResult MusteriSil(int id)
        {
            var x = c.Musteris.Find(id);
            c.Musteris.Remove(x);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MusteriEkle(Musteri m)
        {
            c.Musteris.Add(m);
            c.SaveChanges();
            ViewBag.kayit = "Müşteri Başarıyla Kayıt Edildi.";
            return View();
        }





        // SİPARİŞ İŞLEMLERİ 

        public IActionResult SiparisIndex()
        {
            return View(c.Sipariss.Include(b => b.Musteri).ToList());
        }

        public IActionResult SiparisOnayla(int id)
        {
            var x = c.Sipariss.Find(id);
            x.Durum = "Sipariş Onaylandı";
            c.SaveChanges();
            return RedirectToAction("SiparisIndex");
        }
        public IActionResult SiparisReddet(int id)
        {
            var x = c.Sipariss.Find(id);
            x.Durum = "Sipariş Reddedildi";
            c.SaveChanges();
            return RedirectToAction("SiparisIndex");
        }
        public IActionResult YeniSiparis()
        {
            List<SelectListItem> musteri = (from v in c.Musteris.ToList()
                                            select new SelectListItem
                                            {
                                                Text = v.MusteriAd,
                                                Value = v.MusteriID.ToString()
                                            }).ToList();
            ViewBag.musteri = musteri;
            return View();
        }
        [HttpPost]
        public IActionResult YeniSiparis(Siparis s)
        {
            s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            s.Durum = "Sipariş Beklemede";
            c.Sipariss.Add(s);
            c.SaveChanges();
            ViewBag.skayit = "Sipariş Başarıyla Eklendi.";
            return RedirectToAction("SiparisIndex");
        }


        // ÇIKIŞ İŞLEMİ

        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","AdminLogin");
        }
    }
}
