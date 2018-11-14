using DobrySmaczek.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("CorsPolicy")]
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly DataBaseContext _context;
        //protected readonly ILogger _logger;

        public BaseController(DataBaseContext context)
        {
            //_logger = LogManager.GetCurrentClassLogger();
            _context = context;
        }
    }
}
