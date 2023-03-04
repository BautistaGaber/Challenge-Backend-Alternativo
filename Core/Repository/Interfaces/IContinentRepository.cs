using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Repository.Interfaces
{
    public interface IContinentRepository
    {
        Task<List<Continent>> GetContinents();
        Task SaveChange();
    }
}
