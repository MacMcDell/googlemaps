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
            return View("MultiInfo");
        }

    }
}
