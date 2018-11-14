using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DobrySmaczek.Services.Search;
using DobrySmaczek.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace DobrySmaczek.Controllers
{
    public class SearchController: Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("search")]
        public IActionResult Register(double lat, double lon)
        {
            var response = _searchService.SearchRestaurant(lat, lon);
            if (response.ServiceResponse != ServiceResponseEnum.Ok)
                return StatusCode((int)HttpStatusCode.BadRequest, response.Message);
            return StatusCode((int)HttpStatusCode.OK);
        }
    }
}
