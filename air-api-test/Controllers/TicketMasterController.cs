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
    public class TicketMasterController : ControllerBase
    {
        private readonly airContext _dbContext;
        public TicketMasterController(airContext context)
        {
            this._dbContext = context;
        }

        /// <summary>
        /// Return all data from Ticket Master table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            IEnumerable<TicketMaster> ticketMastersList = (from r in _dbContext.TicketMaster
                                                        select r).ToList();
            if (ticketMastersList.Count() > 0)
            {
                List<Assets> assetsList = (from r in _dbContext.Assets
                                                  join tm in _dbContext.TicketMaster on r.display_id equals tm.assoc_asset_id
                                                    select r).ToList();

                foreach (TicketMaster ticketMaster in ticketMastersList)
                {
                    List<Assets> assets = (from a in assetsList
                                           where a.display_id == ticketMaster.assoc_asset_id
                                           select a).ToList();

                    ticketMaster.Assets = assets;
                }

                return Ok(ticketMastersList);
            }

            return NotFound();
        }

        [HttpGet]
        [Route("getallAssets")]
        public IActionResult GetAllAssets()
        {
            IEnumerable<Assets> ticketMastersList = (from r in _dbContext.Assets
                                                           select r).ToList();
            if (ticketMastersList.Count() > 0)
            {
               
                return Ok(ticketMastersList);
            }

            return NotFound();
        }
    }
}
