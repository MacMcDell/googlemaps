using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleMaps.Models
{
    public class House
    {
        public string PostalCode { get; set; }
        public int SquareFootage { get; set; }
        public bool? ForSale { get; set; }
        public string LatLong { get; set; }
        public string Url { get; set; }
        public string Description { get; set; } 
        //  public List<House> Houses { get; set; } 




        }
}