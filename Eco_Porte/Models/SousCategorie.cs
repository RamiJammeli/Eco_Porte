using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eco_Porte.Models
{
    public class SousCategorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual Categorie categorie { get; set; } 
        public virtual ICollection<Produit> Produits { get; set; }

        public SousCategorie(int id, string nom, Categorie categorie)
        {
            Id = id;
            Nom = nom;
            this.categorie = categorie;
        }
    }
}