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

      

    }
}
