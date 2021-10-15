using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eco_Porte.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<Produit> Produits0 { get; set; }
    }
}