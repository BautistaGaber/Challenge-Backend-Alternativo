using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetContries();
        Task<Country> GetContriesbyId(int id);
        Task<Country> CreateCountry(Country country);
        Task UpdateCountry(Country country);
        Task DeleteCountry(int id);
        Task SaveChanges();
    }
}
