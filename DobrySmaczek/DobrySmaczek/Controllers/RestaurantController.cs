using DobrySmaczek.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Controllers
{
    [Route("api/restaurants")]
    public class RestaurantController: Controller
    {
        private readonly DataBaseContext context;

        public RestaurantController(DataBaseContext context)
        {
            this.context = context;
        }
    }
}
