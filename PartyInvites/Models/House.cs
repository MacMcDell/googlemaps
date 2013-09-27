using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class House
    {
        public string PostalCode { get; set; }
        public int SquareFootage { get; set; }
        public bool? ForSale { get; set; }
        public List<House> Houses { get; set; } 

        


    }
}