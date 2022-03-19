using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisTakipSistemiCore.Models.Entities
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GEOPC\\SQLEXPRESS;database=SiparisCoreDB;Integrated Security=True");
        }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Siparis> Sipariss { get; set; }
    }
}
