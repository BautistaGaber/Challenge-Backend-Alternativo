using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Data;
using ChallengeAlternativo.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlternativo.Core.Repository
{
    public class GeographicIconRepository : IGeographicIconsRepository
    {
        private readonly AplicationDbContext _context;    

        public GeographicIconRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<GeographicIcons> CreateGeographicIcons(GeographicIcons geographicIcons)
        {
           await _context.AddAsync(geographicIcons);
             _context.SaveChanges();
            return geographicIcons;
        }

        public async Task DeleteGeographicsIcons(int id)
        {
           var result = await _context.GeographicIcons.FirstOrDefaultAsync(c => c.Id == id);
            _context.GeographicIcons.Remove(result);
            await SaveChanges();
        }

        public async Task<List<GeographicIcons>> GetGeographicIcons()
        {
            return await _context.GeographicIcons.ToListAsync();
        }

        public async Task<GeographicIcons> GetGeographicIconsById(int id)
        {
            var result = await _context.GeographicIcons.FirstOrDefaultAsync(c => c.Id == id);
            return result;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync(); 
        }

        public async Task UpdateGeographicsIcons(GeographicIcons geographicIcons)
        {
            _context.GeographicIcons.Update(geographicIcons);
        }
    }
}
