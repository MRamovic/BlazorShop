using BlazorShop.Server.EF;
using BlazorShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;

namespace BlazorShop.Server.SignalR
{
    public class DodajArtikalHab:Hub
    {
        public async Task SviArtikli()
        {
            
            Baza DB = new Baza();
            var sviArt = DB.Artikli.ToList();
            
            await Clients.Caller.SendAsync("ArtikalMetoda", sviArt);
        }


        public async Task PrihvatiArtikal(List<Artikal> a)
        {
            Baza DB = new Baza();

            foreach (Artikal art in a)
            {
                DB.Artikli.Add(art);
            }
            Console.WriteLine("U serveru sam!");
            await DB.SaveChangesAsync();
        }
    }
}
