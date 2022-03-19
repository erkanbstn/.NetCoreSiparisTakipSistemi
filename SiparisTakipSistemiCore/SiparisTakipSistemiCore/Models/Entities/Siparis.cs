using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Models.Entities
{
    public class Siparis
    {
        public int SiparisID { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public string Urun { get; set; }
        public string Adres { get; set; }
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
        public string Durum{ get; set; }
        public virtual Musteri Musteri { get; set; }
        public int MusteriID { get; set; }

    }
}
