using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using air_api_test.Models;
using Microsoft.AspNetCore.Authorization;

namespace air_api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        /// <param name="numOfRecords">Nums of records to return</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllRequesters")]
        public IActionResult GetAll(int numOfRecords)
        {
            try
            { 
                IEnumerable<Requesters> requestersList = (from r in _dbContext.Requesters
                                                         select r).Take(numOfRecords).ToList();
                if (requestersList.Count() > 0)
                {
                    return Ok(requestersList);
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
