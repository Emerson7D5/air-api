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
        [Route("GetAllTicketMaster")]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<TicketMaster> ticketMastersList = (from r in _dbContext.TicketMaster
                                                               select r).ToList();
                if (ticketMastersList.Count() > 0)
                {
                    List<Assets> assetsList = (from r in _dbContext.Assets
                                               join tm in _dbContext.TicketMaster on r.display_id equals tm.assoc_asset_id
                                               select r).Distinct().ToList();

                    List<AssetType> assetTypeList = (from a in _dbContext.AssetType
                                               join r in _dbContext.Assets on a.id equals r.ci_type_id
                                               join tm in _dbContext.TicketMaster on r.display_id equals tm.assoc_asset_id
                                               select a).Distinct().ToList();

                    foreach (TicketMaster ticketMaster in ticketMastersList)
                    {
                        List<Assets> assets = (from a in assetsList
                                               where a.display_id == ticketMaster.assoc_asset_id
                                               select a).ToList();
                        if (assets.Count>0)
                        {
                            foreach (Assets asset in assets)
                            {
                                List<AssetType> assetTypes = (from at in assetTypeList
                                                              where at.id == asset.ci_type_id
                                                              select at).ToList();
                                asset.AssetType = assetTypes;
                            }
                        }
                        ticketMaster.Assets = assets;
                    }

                    return Ok(ticketMastersList);
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
