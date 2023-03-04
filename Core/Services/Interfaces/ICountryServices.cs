using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services.Interfaces
{
    public interface ICountryServices
    {
        Task<List<Country>> GetContries();
        Task<Country> CreateCountry(Country country);
        Task UpdateCountry(Country country);
        Task DeleteCountry(int id);
    }
}
