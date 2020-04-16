using BlazorShop.Server.EF;
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
    }
}
