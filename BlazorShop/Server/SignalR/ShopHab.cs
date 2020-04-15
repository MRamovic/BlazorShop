using BlazorShop.Server.EF;
using BlazorShop.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.SignalR
{
    public class ShopHab : Hub
    {
        public async Task SviArtikli()
        {
            Console.WriteLine("U Metodi SviArtikli Hab!");
            Baza NB = new Baza();
            List<Artikal> lArt2 = new List<Artikal>();

            lArt2 = NB.Artikals.ToList();
            Console.WriteLine("Prosla metoda svi artikli Hab!");
            await Clients.Caller.SendAsync("ArtikalMetoda", lArt2);              
        }

        public async Task Korpa(List<Artikal> a)
        {
            Baza NB = new Baza();
            foreach (Artikal art in a)
            {
                NB.KorpaArtikals.Add(new KorpaArtikal(art.Naziv, art.Kolicina, art.Cena));
            }
            await NB.SaveChangesAsync();
           // await Clients.Caller.SendAsync("KorpaMetoda", a);
        }

    }
}
