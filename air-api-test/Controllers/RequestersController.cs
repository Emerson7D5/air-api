using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using air_api_test.Models;

namespace air_api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestersController : ControllerBase
    {
        private readonly airContext _dbContext;

        public RequestersController(airContext context)
        {
            this._dbContext = context;
        }

        /// <summary>
        /// Return all data from requesters table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll(int records)
        {
            IEnumerable<Requesters> requestersList = (from r in _dbContext.Requesters
                                                     select r).Take(records).ToList();
            if (requestersList.Count() > 0)
            {
                return Ok(requestersList);
            }

            return NotFound();
        }
    }
}
