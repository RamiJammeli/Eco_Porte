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
        List<Categorie> categories;   

        public HomeController()
        {
            #region categorie
            Categorie cat1 = new Categorie(1, "Bathroom & spas");
            Categorie cat2= new Categorie(2, "Chambers");

            #endregion
            #region sous categorie
            SousCategorie tongmule = new SousCategorie(1, "Tongs/Mules", cat1) ;
            SousCategorie Disposablebriefs = new SousCategorie(2, "Disposable briefs", cat1) ;
            SousCategorie Disposableshorts = new SousCategorie(3, "Disposable shorts", cat1) ;
            SousCategorie Disposablebras = new SousCategorie(4, "Disposable bras", cat1) ;
            SousCategorie Disposablefittedsheets = new SousCategorie(5, "Disposable fitted sheets", cat1) ;
            SousCategorie Scrubkessa = new SousCategorie(6, "Scrub kessa", cat1) ;
            SousCategorie Headbands = new SousCategorie(7, "Headbands", cat1) ;
            SousCategorie Charlottes = new SousCategorie(8, "Charlottes", cat1) ;

            SousCategorie Slippers = new SousCategorie(9, "Slippers", cat2) ;
            SousCategorie Hygienekit = new SousCategorie(10, "Hygiene kit", cat2) ;
            SousCategorie sewingset = new SousCategorie(11, "Sewing set", cat2) ;
            SousCategorie Vanitysets = new SousCategorie(12, "Vanity set", cat2) ;


            #endregion


       

            #region
            Produit closedslipper = new Produit(1, "slipper", "closed", "15.jpg", Slippers);
            Produit openedslipper = new Produit(2, "open-toed slipper", "open-toed <br/> aa", "1.jpg", Slippers);

            Produit dentalbrush = new Produit(3, "dental brush", "a unique utilization", "2jpg", Hygienekit);
            Produit shavingrazor = new Produit(4, "shaving razor", "a unique utilization", "3.jpg", Hygienekit);
            Produit haircomb = new Produit(5, "hair comb", "a unique utilization", "4.jpg", Hygienekit);

            Produit sewingsett = new Produit(6, "sewingset", "a unique utilization", "4.jpg", sewingset);

            Produit earsticks = new Produit(11, "ear sticks", "a unique utilization", "4.jpg", Vanitysets);
            Produit cottonpads = new Produit(12, "cotton pads", "a unique utilization", "4.jpg", Vanitysets);
            Produit nailfile = new Produit(13, "nail file", "a unique utilization", "4.jpg", Vanitysets);


            Slippers.Produits = new List<Produit>() { closedslipper, openedslipper };
            Hygienekit.Produits = new List<Produit>() { dentalbrush, shavingrazor, haircomb };
            sewingset.Produits = new List<Produit>() { sewingsett};
            Vanitysets.Produits=new List<Produit>() { earsticks, cottonpads, nailfile };


            cat1.souscats = new List<SousCategorie>() { tongmule, Disposablebriefs, Disposableshorts, Disposablebras, Disposablefittedsheets, Scrubkessa, Headbands, Charlottes };
            cat2.souscats = new List<SousCategorie>() { Slippers, Hygienekit, sewingset, Vanitysets };



            this.categories = new List<Categorie>() { cat1, cat2 };

            #endregion



        }
        public ActionResult Index()
        {
            Session["ListCategorie"] = categories;


            return View();
        }

        public ActionResult About()
        {
            Session["ListCategorie"] = categories;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Session["ListCategorie"] = categories;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Service()
        {

            Session["ListCategorie"] = categories;
            return View();
        }

        public ActionResult Blog()
        {
            Session["ListCategorie"] = categories;
            return View();
        }
        public ActionResult Personaliser()
        {
            Session["ListCategorie"] = categories;
            return View();
        }

        public ActionResult Products(int idc, int idsub)
        {
            Session["ListCategorie"] = categories;
            ViewBag.id = idc;
            var categorieselected = categories.Where(c => c.Id == idc).FirstOrDefault();
            var listproduit= categorieselected.souscats.Where(s => s.Id == idsub).FirstOrDefault().Produits;
            return View(listproduit);
        }


    }
}