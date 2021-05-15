using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breweries.Web.Models
{
    public class Brewery
    {
       
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string BreweryType { get; set; }

        public string Street { get; set; }
 
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public string WebsiteUrl { get; set; }

        public string Created { get; set; }
    }
}
