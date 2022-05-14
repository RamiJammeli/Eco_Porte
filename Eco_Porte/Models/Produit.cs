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


    public class commantaires
    {
        private int id;
        private int publication_id;
        private string contenu;
        private DateTime date_commentaire;
    }

    public class joueurs
    {
        private int id;
        private int equipes_id;
        private string nom;
        private string prenom;
        private string email;
        private int numero;
        private int nbr_partie_jouer;

    }

    public class equipes
    {
        private int id;
        private int matchs_id;
        private string nom;
        private int nbr_vic;
        private int nbr_per;
        private int nbr_null;
        private int suspension;


    }
}