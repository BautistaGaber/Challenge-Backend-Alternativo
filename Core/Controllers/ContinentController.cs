using ChallengeAlternativo.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace ChallengeAlternativo.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContinentController : ControllerBase
    {

        private readonly IContinentServices _services;
        public ContinentController(IContinentServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetContinents()
        {
            return Ok(await _services.GetContinents());
        }
    }
}
