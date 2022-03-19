using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiparisTakipSistemiCore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Controllers
{
    public class AdminLoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin a)
        {

            var x = c.Admins.FirstOrDefault(b => b.AdminAd == a.AdminAd && b.AdminParola == a.AdminParola);
            if (x != null)
            {
                HttpContext.Session.SetInt32("AID", x.AdminID);
                return RedirectToAction("Index", "Panel");
            }
            return View();
        }
    }
}
