using air_api_test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace air_api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly airContext _dbContext;
        public LocationsController(airContext context)
        {
            this._dbContext = context;
        }

        /// <summary>
        /// Return all data from locations table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            IEnumerable<Locations> locationsList = (from r in _dbContext.Locations
                                                      select r).ToList();
            if (locationsList.Count() > 0)
            {
                return Ok(locationsList);
            }

            return NotFound();
        }
    }
}
