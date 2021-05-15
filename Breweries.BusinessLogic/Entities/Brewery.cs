using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Breweries.BusinessLogic.Entities
{
    public class Brewery
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("breweryType")]
        public string BreweryType { get; set; }

        [JsonProperty( "street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty( "state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty( "country")]
        public string Country { get; set; }

        [JsonProperty("*honeNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty( "websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

    }

}
