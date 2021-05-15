using Breweries.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breweries.Api.ModelBuilders
{
    public interface IBreweryModelBuilder
    {
        Task<List<Brewery>> ReturnBreweryOnSearchCriteria(string searchCriteria);
        Task<List<Brewery>> ReturnBreweriesByType(string breweryType);
        Task<List<Brewery>> ReturnBreweriesByCity(string city);
    }
}
