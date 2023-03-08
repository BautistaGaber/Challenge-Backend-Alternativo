using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services.Interfaces
{
    public interface IGeographicIconsServices
    {
        Task<List<GeographicIcons>> GetGeographicIcons();
        Task<GeographicIcons> CreateGeographicIcons(CreateGeographicIconsDTO createGeographicIconsDTO);
        Task UpdateGeographicIcons(GeographicIcons geographicIcons);
        Task DeleteGeographicIcons(int id);
    }
}
