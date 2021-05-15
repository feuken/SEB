using Breweries.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Breweries.Api.ModelBuilders
{
    public class BreweryModelBuilder : IBreweryModelBuilder
    {
        public async Task<List<Brewery>> ReturnBreweryOnSearchCriteria(string searchCriteria)
        {
            searchCriteria = searchCriteria.Replace(' ', '_');

            using var client = new HttpClient();
            var url = new Uri($"https://api.openbrewerydb.org/breweries/search?query={searchCriteria}");

            var response = await client.GetAsync(url);

            string json;

            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<List<Brewery>>(json);
        }

        public async Task<List<Brewery>> ReturnBreweriesByType(string breweryType)
        {
            using var client = new HttpClient();
            var url = new Uri($"https://api.openbrewerydb.org/breweries?by_type={breweryType}");

            var response = await client.GetAsync(url);

            string json;

            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<List<Brewery>>(json);
        }

        public async Task<List<Brewery>> ReturnBreweriesByCity(string city)
        {
            city = city.Replace(' ', '_');

            using var client = new HttpClient();
            var url = new Uri($"https://api.openbrewerydb.org/breweries?by_city={city}");

            var response = await client.GetAsync(url);

            string json;

            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<List<Brewery>>(json);
        }
    }
}
