using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Models.Entities
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string AdminAd { get; set; }
        public string AdminParola { get; set; }
    }
}
