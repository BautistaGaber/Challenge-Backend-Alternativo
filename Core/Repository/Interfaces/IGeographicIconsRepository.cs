using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Repository.Interfaces
{
    public interface IGeographicIconsRepository
    {
        Task<List<GeographicIcons>> GetGeographicIcons();
        Task<GeographicIcons> CreateGeographicIcons(GeographicIcons geographicIcons);
        Task UpdateGeographicsIcons(GeographicIcons geographicIcons);
        Task DeleteGeographicsIcons(int id);
        Task SaveChanges();
    }
}
