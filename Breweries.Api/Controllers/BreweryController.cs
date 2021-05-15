using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breweries.Api.ModelBuilders;
using Breweries.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Breweries.Api.Controllers
{
    public class BreweryController : Controller
    {
        private readonly IBreweryModelBuilder _breweryModelBuilder;

        public BreweryController(IBreweryModelBuilder breweryModelBuilder)
        {
            _breweryModelBuilder = breweryModelBuilder;
        }

        [HttpGet("search/{searchCriteria}")]     
        [Produces("application/json")]
        public async Task<ActionResult> GetBreweriesBySearchCriteria(string searchCriteria)
        {
            var result = await _breweryModelBuilder.ReturnBreweryOnSearchCriteria(searchCriteria);

            if (!result.Any())
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetByType/{breweryType}")]
        [Produces("application/json")]
        public async Task<ActionResult> GetBreweriesByBreweryType(string breweryType)
        {
            var result = await _breweryModelBuilder.ReturnBreweriesByType(breweryType);

            if (!result.Any())
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetByCity/{city}")]
        [Produces("application/json")]
        public async Task<ActionResult> GetBreweriesByCitya(string city)
        {
            var result = await _breweryModelBuilder.ReturnBreweriesByCity(city);

            if (!result.Any())
                return NotFound();

            return Ok(result);
        }
    }
}