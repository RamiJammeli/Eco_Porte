using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eco_Porte.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public String Reference { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int? Qte { get; set; }
        public Double? Prix { get; set; }        
        public String Matiere { get; set; }
        public String Image { get; set; }
       
        public virtual SousCategorie souscat { get; set; }

        public Produit(int id, string nom, string description, string image ,SousCategorie sousCategorie)
        {
            Id = id;
            Nom = nom;
            Description = description;
            Image = image;
            souscat = sousCategorie;
           
        }
    }
}