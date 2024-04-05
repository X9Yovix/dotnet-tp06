using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP06.Models
{
    public class Categorie
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<Ouvrage> Ouvrages { get; set; }
    }
}