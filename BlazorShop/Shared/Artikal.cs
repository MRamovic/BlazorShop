using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class Artikal
    {
        public string ID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Cena { get; set; }

        public Artikal() { }
        public Artikal (string n, int k, int c)
        {
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
