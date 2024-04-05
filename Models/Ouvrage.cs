using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //public virtual Categorie Categorie { get; set; }
        public string CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}