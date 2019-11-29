using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Core.Entities;
using MyApi.Core.Models;
using MyApi.Services.Camp.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace core_web_api.Controllers
{
    [Route("api/[controller]")]
    public class CampsController : ControllerBase
    {
        private readonly ICampService _campService;

        public CampsController(ICampService campService)
        {
            _campService = campService;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<CampResource[]>> Get()
        {
            try
            {
                return Ok(await _campService.GetAllCampsAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Occured when processing your request");
            }
            
        }


        [HttpGet("{moniker}")]
        public async Task<ActionResult<CampResource>> Get(string moniker)
        {
            try
            {
                var result = await _campService.GetCampAsync(moniker);
                
                if (result == null)
                    return NotFound("Nothing found mer!!");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Occured when processing your request");
            }

        }

    }
}
