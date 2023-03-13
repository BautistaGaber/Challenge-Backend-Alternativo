using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services.Interfaces
{
    public interface ICountryServices
    {
        Task<List<Country>> GetContries();
        Task<Country> GetContriesbyId(int id);
        Task<Country> CreateCountry(CreateCountryDTO createCoutryDTO);
        Task UpdateCountry(UpdateCountryDTO updateCountryDTO);
        Task DeleteCountry(int id);
    }
}
