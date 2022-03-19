using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiparisTakipSistemiCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Musteri m)
        {
            var x = c.Musteris.FirstOrDefault(b => b.MusteriEmail == m.MusteriEmail && b.MusteriParola == m.MusteriParola);
            if (x != null)
            {
                HttpContext.Session.SetInt32("ID",x.MusteriID);
                return RedirectToAction("Index", "MusteriPanel");
            }
            return View();
        }
        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }




    }
}
