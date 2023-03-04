using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Data;
using ChallengeAlternativo.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlternativo.Core.Repository
{
    public class ContinentRepository : IContinentRepository
    {
        private readonly AplicationDbContext _context;
        public ContinentRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Continent>> GetContinents()
        {
            return await _context.continents.ToListAsync();
        }

        public async Task SaveChange()
        {
           await _context.SaveChangesAsync();
        }
    }
}
