using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Shared
{
    public class ArtikalRacuni
    {
        public int IDA {  get;  set;  }
        public Artikal art { get; set; }
        public int IDR { get;  set;  }
        public Racuni rac { get; set; }

        public ArtikalRacuni() { }

        public ArtikalRacuni(Artikal A, Racuni R)
        {
            IDA  =  A.ID;
            art  =  A;
            IDR  =  R.ID;
            rac =  R;
        }
        
    }
}
