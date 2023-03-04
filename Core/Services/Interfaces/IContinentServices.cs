using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services.Interfaces
{
    public interface IContinentServices
    {
        Task<List<Continent>> GetContinents();
    }
}
