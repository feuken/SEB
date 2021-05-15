using Breweries.BusinessLogic.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Breweries.BusinessLogic.Services
{
    public class BreweryService : IBreweryService
    {
        public async Task<List<Brewery>> GetBreweriesBySearchCriteriaAsync(string searchCriteria)
        {
            using var client = new HttpClient();
            var url = new Uri($"https://localhost:44385/search/{searchCriteria}");

            var response = await client.GetAsync(url);

            string json;

            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<List<Brewery>>(json);
            
        }
        public async Task<List<Brewery>> GetBreweriesByTypeAsync(string breweryType)
        {
            using var client = new HttpClient();
            var url = new Uri($"https://localhost:44385/GetByType/{breweryType}");

            var response = await client.GetAsync(url);

            string json;

            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<List<Brewery>>(json);
        }
        public async Task<List<Brewery>> GetBreweriesByCityAsync(string city)
        {
            using var client = new HttpClient();
            var url = new Uri($"https://localhost:44385/GetByCity/{city}");

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
