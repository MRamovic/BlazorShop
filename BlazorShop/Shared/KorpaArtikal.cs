using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class KorpaArtikal
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Cena { get; set; }

        public KorpaArtikal() { }
        public KorpaArtikal(string n, int k, int c)
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
