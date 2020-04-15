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

        public async Task PrihvatiArtikal(List<Artikal> a)
        {
            Baza NB = new Baza();

            foreach (Artikal art in a)
            {
                NB.Artikli.Add(art);
            }
            Console.WriteLine("U serveru sam!");
            await NB.SaveChangesAsync();
        }



     
    }
}
