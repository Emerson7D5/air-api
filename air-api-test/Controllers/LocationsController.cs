using air_api_test.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class LocationsController : ControllerBase
    {
        private readonly airContext _dbContext;
        public LocationsController(airContext context)
        {
            this._dbContext = context;
        }
        /// <summary>
        /// Return the list of locations
        /// </summary>
        /// <returns>List<Locations></returns>
        [HttpGet]
        [Route("GetAllLocation")]
        public IActionResult GetAll()
        {
            try
            { 
                IEnumerable<Locations> locationsList = (from r in _dbContext.Locations
                                                        select r).ToList();
                if (locationsList.Count() > 0)
                {
                    return Ok(locationsList);
                }

                return NotFound();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
