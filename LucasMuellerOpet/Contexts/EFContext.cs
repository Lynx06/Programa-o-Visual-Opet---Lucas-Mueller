using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LucasMuellerOpet.Models;

namespace LucasMuellerOpet.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers{ get; set; }
    }
}