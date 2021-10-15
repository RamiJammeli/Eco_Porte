using Eco_Porte.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eco_Porte.Context
{
    public class ProduitContext:DbContext
    {
        
        public ProduitContext() : base("ProduitContextDB")
        {
        }
        public DbSet<Produit> Agences { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}