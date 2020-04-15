using BlazorShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.EF
{
    public class Baza : DbContext
    {
        public DbSet<Artikal>  Artikals { get; set; }
        public DbSet<KorpaArtikal> KorpaArtikals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikal>().HasKey(i => i.ID);
            modelBuilder.Entity<KorpaArtikal>().HasKey(i => i.ID);
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UVV87V5;Initial Catalog =BlazorShop; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
    
}
