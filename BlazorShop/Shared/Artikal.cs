using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class Artikal
    {
       // public int ID { get; set; }
        public string SKU { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Cena { get; set; }

        public ICollection<ArtikalRacuni> Racunii { get;  set; }

        public Artikal() { }
     
        public Artikal(string s,string n, int k, int c)
        {
            SKU = s;
            Naziv = n;
            Kolicina = k;
            Cena = c;
        }
        
        public override string ToString()
        {
            return $"   { Naziv} ----  {Kolicina} - {Cena}  ";
        }
    }
}
