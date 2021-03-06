﻿using BlazorShop.Shared;
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
        public DbSet<ArtikalRacuni> ArtikalRacunis { get; set; }
        public DbSet<Racuni> Racunis { get; set; }
        public DbSet<User> Users { get;  set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Username);
            modelBuilder.Entity<Artikal>().HasKey(i => i.SKU);




            modelBuilder.Entity<ArtikalRacuni>().HasKey(ar => new { ar.IDA, ar.IDR });
            modelBuilder.Entity<ArtikalRacuni>().HasOne(ar => ar.art).WithMany(k => k.Racunii).HasForeignKey(ar=>ar.IDA);
            modelBuilder.Entity<ArtikalRacuni>().HasOne(ar => ar.rac).WithMany(k => k.PoruceniArtikli).HasForeignKey(ar => ar.IDR);

            modelBuilder.Entity<Racuni>().HasOne(u => u.kor).WithMany(k => k.KolekcijaRacuna).HasForeignKey(uk => uk.korID);

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UVV87V5;Initial Catalog =BlazorShop; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
    
}
