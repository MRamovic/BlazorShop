using BlazorShop.Shared;
using BlazorShop.Server.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorShop.Server.SignalR
{
    public class LoginReg :Hub
    {
		public async Task ProveriKorisnika(User LogIn)
		{
			EF.Baza DB = new EF.Baza();

			var juzer = DB.Users.Where(us => us.Equals(LogIn)).FirstOrDefault();

			if (juzer != null)
			{
				await Clients.Caller.SendAsync("EvoJuzera", juzer);
			}
			
		}
		public async Task PrihvatiKorisnika(User u)
		{
			EF.Baza DB = new EF.Baza();
			DB.Add(u);
			await DB.SaveChangesAsync();

		}
	}
}
