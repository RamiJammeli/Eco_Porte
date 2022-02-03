using Eco_Porte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eco_Porte.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            Categorie cat1 = new Categorie(1, "Bathroom & spas");
            Categorie cat2= new Categorie(2, "Chambers");


            Produit p1 = new Produit(1,"slipper","not covered","ddd", cat2);
            Produit p2 = new Produit(2, "Disposable bras", "not covered", "ddd", cat1);
            Produit p3 = new Produit(3, "Headbands", "not covered", "ddd", cat1);
            Produit p4 = new Produit(4, "sewing set", "not covered", "ddd", cat2);
            List <Produit>produits=new List<Produit>();
            produits.Add(p1);
            produits.Add(p2);
            produits.Add(p3);
            produits.Add(p4);

            cat1.Produits = produits;


        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Service()
        {
            

            return View();
        }

        public ActionResult Blog()
        {

            return View();
        }
        public ActionResult Personaliser()
        {

            return View();
        }

        public ActionResult Products()
        {

            return View();
        }


    }
}