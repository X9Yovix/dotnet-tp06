using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP06.Models
{
    public class Ouvrage
    {
        public string Id { get; set; }
        public string Titre { get; set;}
        public string Descriptif { get; set;}
        public decimal Prix { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}