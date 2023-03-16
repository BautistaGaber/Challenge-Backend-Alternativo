using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Helper;
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

        public async Task<Country> CreateCountry(CreateCountryDTO createCountryDTO)
        {
            return await _repository.CreateCountry(ApiHelper.CreateCountryDtoToEntity(createCountryDTO));            
        }

        public async Task DeleteCountry(int id)
        {
            await _repository.DeleteCountry(id);
        }

        public async Task<List<Country>> GetContries()
        {
            return await _repository.GetContries();
        }

        public Task<Country> GetContriesbyId(int id)
        {
            return _repository.GetContriesbyId(id);
        }

        public async Task UpdateCountry(UpdateCountryDTO updateCountryDTO, int id)
        {
            Country country = await _repository.GetContriesbyId(id);
            if (country == null)
                return;
            await _repository.UpdateCountry(ApiHelper.UpdateCountryDtoToEntity(updateCountryDTO, country));     
            await _repository.SaveChanges();
        }
    }
}
