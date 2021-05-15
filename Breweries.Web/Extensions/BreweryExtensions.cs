using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breweries.Web.Extensions
{
    public static class BreweryExtensions
    {
        public static Models.Brewery ToModel(this BusinessLogic.Entities.Brewery entity)
        {
            return new Models.Brewery
            {
                Id = entity.Id,
                Name = entity.Name,
                Street = entity.Street,
                PostalCode = entity.PostalCode,
                City = entity.City,
                Country = entity.Country,
                State = entity.State,
                WebsiteUrl = string.IsNullOrEmpty(entity.WebsiteUrl) ? "" : entity.WebsiteUrl,
                PhoneNumber = string.IsNullOrEmpty(entity.PhoneNumber) ? "" : entity.PhoneNumber,
                BreweryType = entity.BreweryType,
                Created = entity.Created
            };
        }
    }
}
