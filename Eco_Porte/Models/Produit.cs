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
        public virtual Categorie categorie { get; set; }
    }
}