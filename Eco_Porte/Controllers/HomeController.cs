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
            Categorie cat1 = new Categorie(1, "Produits SPA");
            Categorie cat2= new Categorie(2, "Produits Chambre ");

            #endregion
            #region sous categorie
            SousCategorie Usageunique = new SousCategorie(1, "Usage unique", cat1) ;
            SousCategorie DiversSPA = new SousCategorie(2, "Divers SPA", cat1) ;
            SousCategorie GammeCosmetiques = new SousCategorie(3, "Cosmétiques", cat1) ;
           

            SousCategorie Slippers = new SousCategorie(4, "Slippers", cat2) ;
            SousCategorie ProduitsDaccueil = new SousCategorie(5, "Produits D'accueil", cat2) ;
            SousCategorie DiversChambre = new SousCategorie(6, "Divers Chambre", cat2) ;
            #endregion


            #region produits spa
            Produit tongsfemme = new Produit(22, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/ssqsf.png", Usageunique);
            Produit tongshomme = new Produit(23, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/qdsqf.png", Usageunique);
            Produit mulefemme = new Produit(24, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit mulehomme = new Produit(25, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/8F7A9019.jpg", Usageunique);
            Produit slipfemme = new Produit(26, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit sliphomme = new Produit(27, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit shorthomme = new Produit(28, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit charlotteimperméable = new Produit(29, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/charlotte-impermeable-en-pe-.jpg", Usageunique);
            Produit charlottteTNT = new Produit(30, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/19007_BL.png", Usageunique);
            Produit surchaussurePE = new Produit(31, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit surchaussureTNT = new Produit(32, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit brassiere = new Produit(33, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/61TV3T.jpg", Usageunique);
            Produit peignoir = new Produit(34, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/large.jpg", Usageunique);
            Produit pareo = new Produit(35, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit draphousse = new Produit(36, "open-toed slipper", "open-toed <br/> aa", "16.jpg", Usageunique);
            Produit houssetetiere = new Produit(37, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/fcbx_praxis.jpg", Usageunique);
            Produit serviette = new Produit(38, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/femme-serviette.jpg", Usageunique);
            Produit gantdegommage = new Produit(39, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/41gTKXsutPL._AC_.jpg", Usageunique);
            Produit tapisantiderapant = new Produit(40, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/31Ms0TLGYqL._AC_.jpg", Usageunique);
            Produit rouleauxTNT = new Produit(41, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/Disposable.jpg", Usageunique);
            Produit rouleauxenveloppement = new Produit(42, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/dispasble products/rouleau-drap-denveloppement.jpg", Usageunique);


            Produit sacimpermeable = new Produit(43, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/the wrd od spa prod/sac-joaquine.png", DiversSPA);
            Produit sacdeplage = new Produit(44, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/the wrd od spa prod/téléchargement.jpg", DiversSPA);
            Produit troussedetoilette = new Produit(45, "open-toed slipper", "open-toed <br/> aa", "16.jpg", DiversSPA);

            Produit gommagecorps = new Produit(46, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/the word os cosmetics/GOMMAGES.jpeg", GammeCosmetiques);
            Produit enveloppementcorps = new Produit(47, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);
            Produit huilesdemassage = new Produit(48, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/the word os cosmetics/Huiles.jpg", GammeCosmetiques);
            Produit baumedemassage = new Produit(49, "open-toed slipper", "open-toed <br/> aa", "SPA PRODUCTS/the word os cosmetics/norme.png", GammeCosmetiques);
            Produit bougiedemassage = new Produit(50, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);
            Produit savon = new Produit(51, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);
            Produit ghassoul = new Produit(52, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);
            Produit cire = new Produit(53, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);
            Produit brumeambiance = new Produit(54, "open-toed slipper", "open-toed <br/> aa", "16.jpg", GammeCosmetiques);

            
            #endregion


            #region produits chambre
            Produit slippersouvertsimple = new Produit(1, "slipper", "By far our most popular item. We pay great attention to our game-changers atEcoporté because we feel they contribute to the degree of comfort for your guests and enrich their stay experience. <br/> Our slippers, whether closed or open - toed, offer a distinctive touch to your institution and even more originality with our \"customization\" option, which allows you to pu your own unique touch on them.", "CHAMBERS PRODUCTS/the world os SLIPPERS/b.png", Slippers);
            Produit slippersouvertdouble = new Produit(2, "open-toed slipper", "open-toed <br/> aa", "CHAMBERS PRODUCTS/the world os SLIPPERS/a.png", Slippers);
            Produit slipperferme = new Produit(3, "open-toed slipper", "open-toed <br/> aa", "CHAMBERS PRODUCTS/the world os SLIPPERS/c.png", Slippers);
            Produit slipperfermedouble = new Produit(4, "open-toed slipper", "open-toed <br/> aa", "CHAMBERS PRODUCTS/the world os SLIPPERS/d.png", Slippers);
            Produit slippersouvert = new Produit(5, "open-toed slipper", "open-toed <br/> aa", "17.jpg", Slippers);
            Produit slippersferme = new Produit(6, "open-toed slipper", "open-toed <br/> aa", "18.jpg", Slippers);


            Produit PeigneBambou = new Produit(7, "dental brush", "a unique utilization", "CHAMBERS PRODUCTS/the worl of hotel welcom basket/p.png", ProduitsDaccueil);
            Produit kitrasagebambou = new Produit(8, "shaving razor", "a unique utilization", "CHAMBERS PRODUCTS/the worl of hotel welcom basket/shave.png", ProduitsDaccueil);
            Produit kitdentairebambou = new Produit(9, "hair comb", "a unique utilization", "CHAMBERS PRODUCTS/the worl of hotel welcom basket/PAR CATEGORE/KIT DENTAIRE.png", ProduitsDaccueil);
            Produit kitcouture = new Produit(10, "sewingset", "a unique utilization", "CHAMBERS PRODUCTS/the worl of hotel welcom basket/qq.png", ProduitsDaccueil);
            Produit vanitykit = new Produit(11, "ear sticks", "a unique utilization", "4.jpg", ProduitsDaccueil);
            Produit bonnetdouche = new Produit(12, "cotton pads", "a unique utilization", "4.jpg", ProduitsDaccueil);
            Produit sachethygiene = new Produit(13, "nail file", "a unique utilization", "4.jpg", ProduitsDaccueil);
            Produit epongechaussure = new Produit(14, "nail file", "a unique utilization", "4.jpg", ProduitsDaccueil);


            Produit chaussepied = new Produit(15, "nail file", "a unique utilization", "4.jpg", DiversChambre);
            Produit cintrebois = new Produit(16, "nail file", "a unique utilization", "CHAMBERS PRODUCTS/the world of chamber accesories/austria-trend-hotel-ljubljana.png", DiversChambre);
            Produit saclinge = new Produit(17, "nail file", "a unique utilization", "CHAMBERS PRODUCTS/the world of chamber accesories/téléchargement.jpg", DiversChambre);
            Produit cintreboisavecoince = new Produit(18, "nail file", "a unique utilization", "4.jpg", DiversChambre);
            Produit houssevetement = new Produit(19, "nail file", "a unique utilization", "CHAMBERS PRODUCTS/the world of chamber accesories/Luluhut.jpg", DiversChambre);
            Produit masqueoccultant = new Produit(20, "nail file", "a unique utilization", "CHAMBERS PRODUCTS/the world of chamber accesories/Masque.jpg", DiversChambre);
            Produit setfeminin = new Produit(21, "nail file", "a unique utilization", "4.jpg", DiversChambre);




            Usageunique.Produits = new List<Produit>() { charlottteTNT,charlotteimperméable, brassiere, houssetetiere, peignoir, gantdegommage, tongsfemme, tongshomme, mulehomme, tapisantiderapant, rouleauxTNT, rouleauxenveloppement, serviette };
            DiversSPA.Produits = new List<Produit>() { sacimpermeable, sacdeplage, troussedetoilette };
            GammeCosmetiques.Produits = new List<Produit>() { gommagecorps, baumedemassage, huilesdemassage };

            Slippers.Produits = new List<Produit>() { slippersouvertsimple, slippersouvertdouble, slipperferme, slipperfermedouble, slippersouvert, slippersferme };
            ProduitsDaccueil.Produits = new List<Produit>() { PeigneBambou, kitrasagebambou, kitdentairebambou, kitcouture, vanitykit, bonnetdouche, sachethygiene, epongechaussure };
            DiversChambre.Produits = new List<Produit>() { chaussepied, cintrebois, saclinge, cintreboisavecoince, houssevetement, masqueoccultant, setfeminin };
            


            cat1.souscats = new List<SousCategorie>() { Usageunique, DiversSPA, GammeCosmetiques};
            cat2.souscats = new List<SousCategorie>() { Slippers, ProduitsDaccueil, DiversChambre};



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