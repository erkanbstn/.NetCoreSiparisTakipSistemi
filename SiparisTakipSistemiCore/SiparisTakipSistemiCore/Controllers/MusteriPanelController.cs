using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiparisTakipSistemiCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Controllers
{
    public class MusteriPanelController : Controller
    {
        Context c = new Context();

        // Profil İşlemleri
        public IActionResult Index()
        {
            var x = HttpContext.Session.GetInt32("ID");
            var x2 = c.Musteris.Find(x);
            return View(x2);
        }
        [HttpPost]
        public IActionResult Index(Musteri m)
        {
            var x = HttpContext.Session.GetInt32("ID");
            var x2 = c.Musteris.Find(x);
            x2.MusteriAd = m.MusteriAd;
            x2.MusteriTelefon = m.MusteriTelefon;
            x2.MusteriEmail = m.MusteriEmail;
            x2.MusteriParola = m.MusteriParola;
            c.SaveChanges();
            ViewBag.guncel = "Bilgiler Başarıyla Güncellendi.";
            return View();
        }






        public IActionResult Siparislerim()
        {
            var x = HttpContext.Session.GetInt32("ID");
            var x2 = c.Sipariss.Where(b => b.MusteriID == x);
            return View(x2);
        }

        // Sipariş Oluşturma İşlemi
        public IActionResult YeniSiparis()
        {
            var x = HttpContext.Session.GetInt32("ID");
            var x2 = c.Musteris.Find(x);
            ViewBag.telefon=x2.MusteriTelefon;
            ViewBag.eposta=x2.MusteriEmail;
            return View();
        }
        [HttpPost]
        public IActionResult YeniSiparis(Siparis s)
        {
            var x = HttpContext.Session.GetInt32("ID");
            s.MusteriID = Convert.ToInt32(x);
            s.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Sipariss.Add(s);
            c.SaveChanges();
            ViewBag.skayit = "Sipariş Başarıyla Eklendi.";
            return RedirectToAction("Siparislerim");
        }
    }
}
