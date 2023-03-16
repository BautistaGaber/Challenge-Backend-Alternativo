using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.Core.Services.Interfaces
{
    public interface IGeographicIconsServices
    {
        Task<List<GeographicIcons>> GetGeographicIcons();
        Task<GeographicIcons> CreateGeographicIcons(CreateGeographicIconsDTO createGeographicIconsDTO);
        Task<GeographicIcons> UpdateGeographicIconsById(int id);
        Task UpdateGeographicIcons(UpdateGeographicIconsDTO updateGeographicIconsDTO, int id);
        Task DeleteGeographicIcons(int id);
    }
}
