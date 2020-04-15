using BlazorShop.Server.EF;
using BlazorShop.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.SignalR
{
    public class hab : Hub    
    {
        public async Task JaviServeru()
        {
            await Clients.Caller.SendAsync("ServerMetoda", "Server je dostupan!");
        }

      
    }
}
