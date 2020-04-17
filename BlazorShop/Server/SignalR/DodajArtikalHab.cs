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

        
        public async Task PrihvatiArtikal(List<Artikal> a)
        {



            Console.WriteLine("U metodi PrihvatiArtikal sam!");
            Baza NB = new Baza();

            foreach (Artikal art in a)
            {
                Console.WriteLine($"{art.Naziv}");
                NB.Artikals.Add(new Artikal(art.Naziv, art.Kolicina, art.Cena));
            }

            await NB.SaveChangesAsync();


            //    Console.WriteLine("U metodi PrihvatiArtikal sam!");
            //    Baza NB = new Baza();
            //    var la = NB.Artikals.ToList();
            //    if (la.Count == 0)
            //    {
            //        foreach (Artikal art in a)
            //        {
            //            NB.Artikals.Add(new Artikal(art.Naziv, art.Kolicina, art.Cena));
            //        }
            //    }
            //    else
            //    {

            //        foreach (Artikal art in a)
            //        {
            //            foreach (Artikal art2 in la)
            //            {
            //                if (art.ID == art2.ID)
            //                {
            //                    NB.Artikals.Find(art.ID).Kolicina += art.Kolicina;
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{art.Naziv}");
            //                    NB.Artikals.Add(new Artikal(art.Naziv, art.Kolicina, art.Cena));
            //                }
            //            }
            //        }
            //    }
            //    await NB.SaveChangesAsync();

        }
    }
}


