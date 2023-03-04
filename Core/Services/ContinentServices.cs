using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services
{
    public class ContinentServices : IContinentServices
    {

        private readonly IContinentRepository _repository;

        public ContinentServices(IContinentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Continent>> GetContinents()
        {
            return await _repository.GetContinents();
        }
    }
}
