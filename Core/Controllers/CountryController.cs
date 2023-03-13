using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.DTOs;
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

        [HttpGet]
        [Route("/SerchCountries/{id}")]
        public async Task<IActionResult> GetCountriesbyId([FromRoute]int id)
        {
            return Ok(await _services.GetContriesbyId(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCountry(CreateCountryDTO createCountryDTO)
        {
            var result = await _services.CreateCountry(createCountryDTO);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCountry(UpdateCountryDTO updateCountryDTO, [FromQuery]int id)
        {
            var result = _services.UpdateCountry(updateCountryDTO, id);
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
