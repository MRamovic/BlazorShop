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
            Console.WriteLine("Prosao await");
        }

        public async Task PretragaArtikla(string r)
        {
            
            Baza NB = new Baza();
            var lArt3 = NB.Artikals.Where(x => x.Naziv.Contains(r) || x.SKU.Contains(r)).ToList(); 
            await Clients.Caller.SendAsync("ArtikalMetoda", lArt3);
          
        }
        public async Task ArtikliIzKorpe(Artikal a, List<Artikal> lart)
        {
            Baza NB = new Baza();
            
            var artikal = NB.Artikals.Find(a.SKU);
            
           
            for (int x=0; x<lart.Count; x++)
            {
                if(lart[x].SKU==artikal.SKU)
                {
                    lart[x].Kolicina -= 1;
                }
            }
            
            await Clients.Caller.SendAsync("ArtikalMetoda2",lart);
            
        }

    }
}
