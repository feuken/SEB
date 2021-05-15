using Breweries.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Breweries.BusinessLogic.Services
{
    public interface IBreweryService
    {
        Task<List<Brewery>> GetBreweriesBySearchCriteriaAsync(string searchCriteria);
        Task<List<Brewery>> GetBreweriesByTypeAsync(string breweryType);
        Task<List<Brewery>> GetBreweriesByCityAsync(string city);
    }
}
