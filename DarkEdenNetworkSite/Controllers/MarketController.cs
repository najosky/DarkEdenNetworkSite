using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DarkEdenNetworkSite.Models;
using DarkEdenNetworkSite.Models;
namespace DarkEdenNetworkSite.Controllers
{
    public class MarketController : Controller
    {
        // GET: Home
        public ActionResult Slayer()
        {
            var list = new DARKEDENEntities();
            var items = list.GoodsListInfoes.Where(m => m.Race == "SLAYER").Take(10);

            return View(items.ToList());
        }

        public ActionResult Vampire()
        {
            var list = new DARKEDENEntities();
            var items = list.GoodsListInfoes.Where(m => m.Race == "VAMPIRE").Take(10);


            return View(items.ToList());
        }

        public ActionResult Ouster()
        {
            var list = new DARKEDENEntities();
            var items = list.GoodsListInfoes.Where(m => m.Race == "OUSTERS").Take(10);


            return View(items.ToList());
        }

        public ActionResult Common()
        {
            var list = new DARKEDENEntities();
            var items = list.GoodsListInfoes.Where(m => m.Race == "COMMON").Take(10);
            return View(items.ToList());
        }

        [HttpPost]
        public ActionResult BuyGold(FormCollection form) 
        {
            JsonConnection j = new Models.JsonConnection();
            string path = "C:/Users/Caleb Bain/Documents/GitHub/DarkEdenNetworkSite/DarkEdenNetworkSite/Json/Gold.json";
            int gold = j.Read<int>(path);
            gold += int.Parse(form["Amount"]);
            j.Write<int>(path, gold);
            return Redirect("/Home/Market");
        }
    }
}