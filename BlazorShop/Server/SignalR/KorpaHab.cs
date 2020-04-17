﻿using BlazorShop.Server.EF;
using BlazorShop.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.SignalR
{
    public class KorpaHab : Hub
    {

        public async Task KorpaRacun(List<Artikal> la)
        {
            Baza NB = new Baza();

            var rac=new Racuni();
            var lisart = new List<Artikal>();

            foreach(Artikal a in la)
            {
                lisart.Add(NB.Artikals.Find(a.ID));
            }

            NB.Racunis.Add(rac);

            foreach (Artikal a in lisart)
            {
                NB.ArtikalRacunis.Add(new ArtikalRacuni(a, rac));
            }
            NB.SaveChanges();
        }

        public async Task BrisanjeIzBaze(List<Artikal> la)
        {
            Console.WriteLine("U metodi brisanje sam!");
            Baza NB = new Baza();
            var sad  = NB.Artikals.ToList();
            foreach(Artikal ar in sad)
            {
                foreach (Artikal ar2 in la)
                {
                    if(ar.ID==ar2.ID)
                    {
                        NB.Artikals.Find(ar2.ID).Kolicina -= ar2.Kolicina;
                        await NB.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
