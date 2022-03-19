using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Models.Entities
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriEmail { get; set; }
        public string MusteriParola { get; set; }
        public string MusteriTelefon { get; set; }
        public List<Siparis> Siparis { get; set; }
    }
}
