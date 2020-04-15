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
        public async Task Korpa2()
        {
            Baza NB = new Baza();
            var art = NB.KorpaArtikals.ToList();
            await Clients.Caller.SendAsync("KorpaMetoda", art);   
        }

        public async Task KorpaRacun()
        {
            Baza NB = new Baza();
            var art = NB.KorpaArtikals.ToList();
            await Clients.Caller.SendAsync("RacunMetoda", art);
            NB.KorpaArtikals.RemoveRange();

        }
    }
}
