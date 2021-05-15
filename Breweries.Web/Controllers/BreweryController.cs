using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breweries.BusinessLogic.Services;
using Breweries.Web.Extensions;
using Breweries.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Breweries.Web.Controllers
{
    [Route("Brewery")]
    public class BreweryController : Controller
    {
        private readonly IBreweryService _breweryService;
        public BreweryController(IBreweryService breweryService)
        {
            _breweryService = breweryService;
        }
        [Route("/", Name = "LandingPage")]
        public IActionResult Index()
        {           
            return View();
        }

        [HttpPost("Search")]
        public IActionResult Search([FromBody]string searchCriteria)
        {
            var result = _breweryService.GetBreweriesBySearchCriteriaAsync(searchCriteria);

            if (result.Result == null)
                return Json(new List<Brewery>());

                result.Result.Select(p => p.ToModel());

                return Json(result.Result.Select(p => p.ToModel()));
        }

        [HttpPost("GetByBreweryType")]
        public IActionResult GetByType([FromBody]string breweryType)
        {
            var result = _breweryService.GetBreweriesByTypeAsync(breweryType);
            
            if (result.Result == null)
                return Json(new List<Brewery>());

            result.Result.Select(p => p.ToModel());

            return Json(result.Result.Select(p => p.ToModel()));
        }
        [HttpPost("GetByCity")]
        public IActionResult GetByCity([FromBody]string city)
        {
            var result = _breweryService.GetBreweriesByCityAsync(city);
            
            if (result.Result == null)
                return Json(new List<Brewery>());

            result.Result.Select(p => p.ToModel());

            return Json(result.Result.Select(p => p.ToModel()));
        }
    }
}