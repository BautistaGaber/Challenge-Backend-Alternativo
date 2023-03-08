using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAlternativo.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeographicsIconsController : ControllerBase
    {
        private readonly IGeographicIconsServices _services;
        public GeographicsIconsController(IGeographicIconsServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetGeographicIcons()
        {
            return Ok(await _services.GetGeographicIcons());
        }

        [HttpPost]
        public async Task<IActionResult> CreateGeographicIcons(CreateGeographicIconsDTO createGeographicIconsDTO)
        {
            var result = await _services.CreateGeographicIcons(createGeographicIconsDTO);
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGeographicIcons(GeographicIcons geographicIcons)
        {
            var result = _services.UpdateGeographicIcons(geographicIcons);
            if(result == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGeographicIcons(int id)
        {
            var result =  _services.DeleteGeographicIcons(id);
            if (result == null)
            {
              return BadRequest();
            }
              return Ok();
        }
    }
}
