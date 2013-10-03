using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleMaps.Models;

namespace GoogleMaps.Controllers
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


        private  string Locations()
        {

            var houses = new List<House>
                {
new House {Description = "Description", ForSale = true, LatLong = "32.710616,-117.165191", PostalCode = "v5k2j6", SquareFootage = 123, Url = "http://www.cnn.com"},
new House {Description = "Description", ForSale = true, LatLong = "33.710616,-117.165191", PostalCode = "v5k2j6", SquareFootage = 123, Url = "http://www.cnn.com"},
new House {Description = "Description", ForSale = true, LatLong = "34.710616,-117.165191", PostalCode = "v5k2j6", SquareFootage = 123, Url = "http://www.cnn.com"},
new House {Description = "Description", ForSale = true, LatLong = "35.710616,-117.165191", PostalCode = "v5k2j6", SquareFootage = 123, Url = "http://www.cnn.com"},
new House {Description = "Description", ForSale = true, LatLong = "36.710616,-117.165191", PostalCode = "v5k2j6", SquareFootage = 123, Url = "http://www.cnn.com"}
         
                };

            var sb = new System.Text.StringBuilder();
            int i = 1; 
            //foreach (var house in houses)
            //{
            //    sb.Append(string.Format("['{0}',{1},{2}],", house.Description, house.LatLong, i));
            //    i++;
            //}
            double lat = 32.710616;
            double lon = -117.165191;
            for (int j = 0; j < 150; j++)
            {
              var house = new House
                    {
                        Description = "Desc" + j.ToString(),
                        ForSale = true,
                        LatLong = lat.ToString() + "," + lon.ToString(),
                        PostalCode = "v5k2j6",
                        SquareFootage = 123,
                        Url = "http://www.cnn.com"
                    };

                sb.Append(string.Format("['{0}',{1},{2}],", house.Description, house.LatLong, i));
                  lat = lat + .15;
                lon = lon - .15; 
            }



            return sb.ToString().TrimEnd(',');
            //return "['San Diego Childrems museum' ,32.710616,-117.165191,1], " +
            //       "['<h1 id=\"firstHeading\">Pinnacle Marina Tower</h1><div> <div style=\float:left\"> <img src=\"/content/images/museumTwr2.jpg\" alt=\"pinnacle tower\" /> </div>Situated in the ultimate Marina location overlooking the Bay, the 36 storey Pinnacle Museum Tower is a dramatic glass and solid concrete structure soaring 450 feet above the building’s Great Lobby. San Diego’s second tallest residential tower, The Pinnacle is a stone and marble architectural triumph filled with natural overhead light.</div>', 32.710072,-117.165121,2]";

        }

    }
}
