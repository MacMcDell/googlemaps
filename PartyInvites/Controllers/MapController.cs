using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class MapController : Controller
    {
        //
        // GET: /Map/

        public ActionResult Index()
        {
            return View("index");
        }
        public  ActionResult InfoMap()
        {
            return View("infomap");
        }

        public ActionResult MultiInfo()
        {
            ViewBag.Locations = Locations(); 
            return View("MultiInfo");
           
        }


        private static string Locations()
        {


            return "['San Diego Childrems museum' ,32.710616,-117.165191,1], " +
                   "['<h1 id=\"firstHeading\">Pinnacle Marina Tower</h1><div> <div style=\float:left\"> <img src=\"/content/images/museumTwr2.jpg\" alt=\"pinnacle tower\" /> </div>Situated in the ultimate Marina location overlooking the Bay, the 36 storey Pinnacle Museum Tower is a dramatic glass and solid concrete structure soaring 450 feet above the building’s Great Lobby. San Diego’s second tallest residential tower, The Pinnacle is a stone and marble architectural triumph filled with natural overhead light.</div>', 32.710072,-117.165121,2]";

         


        }

    }
}
