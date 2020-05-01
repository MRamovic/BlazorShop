using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;

namespace BlazorShop.Shared
{
    public class User
    {
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = " Obavezno polje. Min = 5, max=20 karaktera")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Obavezno polje. Min=5, max=20 karaktera")]
        public string Password { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Obavezno polje. Max. 20 karaktera")]
        public string ImeKorisnika { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Obavezno polje. Max. 20 karaktera")]
        public string PrezimeKorisnika { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Obavezno polje. Max. 20 karaktera")]
        public string GradKorisnika { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Obavezno polje. Max. 20 karaktera")]
        public string AdresaKorisnika { get; set; }

        [Required]
        [EmailAddress] 
        public string EmailKorisnika {get;set;}

        [Required]
        [Phone]
        public string KontaktKorisnika { get; set; }



        public bool Administrator { get; set; } 
       
       

        public ICollection<Racuni> KolekcijaRacuna { get; set; }
        

        public User() { }

        

        public override bool Equals(object obj)
        {
            if (obj is User u && u.Username == this.Username && u.Password == this.Password)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Username.GetHashCode();

        }
    }
}
