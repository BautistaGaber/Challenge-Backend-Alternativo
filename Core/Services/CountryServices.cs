using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services
{
    public class CountryServices : ICountryServices
    {
        private readonly ICountryRepository _repository;
        public CountryServices(ICountryRepository repository)
        {
            _repository = repository;     
        }

        public async Task<Country> CreateCountry(Country country)
        {
            return await _repository.CreateCountry(country);            
        }

        public async Task DeleteCountry(int id)
        {
            await _repository.DeleteCountry(id);
        }

        public async Task<List<Country>> GetContries()
        {
            return await _repository.GetContries();
        }

        public async Task UpdateCountry(Country country)
        {
            await _repository.UpdateCountry(country);
        }
    }
}
