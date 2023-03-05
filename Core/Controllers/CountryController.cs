using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAlternativo.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryServices _services;

        public CountryController(ICountryServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(await _services.GetContries());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCountry(Country country)
        {
            var result = await _services.CreateCountry(country);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountry(Country country)
        {
            var result = _services.UpdateCountry(country);
                if (result == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var result = _services.DeleteCountry(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
