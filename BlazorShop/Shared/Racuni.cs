using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class Racuni
    {
        public int ID { get; set; }
        public DateTime DatumIzdavanjaRacuna { get; set; } =  DateTime.Now;
        
        public ICollection<ArtikalRacuni> PoruceniArtikli { get;  set; }
        
        public Racuni() { }
        //public Racuni(DateTime DIR)
        //{
        //    DatumIzdavanjaRacuna = DIR;
        //}
    }
}
