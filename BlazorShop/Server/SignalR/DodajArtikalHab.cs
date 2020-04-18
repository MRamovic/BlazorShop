using BlazorShop.Server.EF;
using BlazorShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;

namespace BlazorShop.Server.SignalR
{
    public class DodajArtikalHab : Hub
    {


        public async Task PrihvatiArtikal(List<Artikal> a)
        {

            Console.WriteLine("U metodi PrihvatiArtikal sam!");
            Baza NB = new Baza();
            var la = NB.Artikals.ToList();


            if (la.Count == 0)
            {
                foreach (Artikal art in a)
                {
                    NB.Artikals.Add(new Artikal(art.SKU, art.Naziv, art.Kolicina, art.Cena));
                    Console.WriteLine("Lista prazna, pravim novi artikal!");
                }
            }
            else
            {
   
                    Console.WriteLine("Prvi foreach");
                    foreach (Artikal art in a)
                    {
                    var promenljiva = NB.Artikals.Find(art.SKU);
                        Console.WriteLine("Drugi foreach");
                        if (promenljiva!=null)
                        {
                            Console.WriteLine("If u foreach");
                            promenljiva.Kolicina += art.Kolicina;
                        }
                        else
                        {
                            {
                                Console.WriteLine($"U else sam + novi {art}");
                                NB.Artikals.Add(new Artikal(art.SKU, art.Naziv, art.Kolicina, art.Cena));
                            }
                        }
                    }

            }
            await NB.SaveChangesAsync();



        }

    }
}



