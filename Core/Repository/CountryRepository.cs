using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Data;
using ChallengeAlternativo.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlternativo.Core.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AplicationDbContext _context;
        public CountryRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetContries()
        {
            return await _context.countries.ToListAsync();
        }

        public async Task<Country> GetContriesbyId(int id)
        {
            var result = await _context.countries.FirstOrDefaultAsync(c => c.Id == id);
            return result;
        }

        public async Task<Country> CreateCountry(Country country)
        {
            await _context.countries.AddAsync(country);
            _context.SaveChanges();
            return country;
        }

        public async Task DeleteCountry(int id)
        {
            var result = await _context.countries.FirstOrDefaultAsync(c => c.Id == id);
            _context.countries.Remove(result);
            await SaveChanges();
        }

        public async Task UpdateCountry(Country country)
        {
            _context.countries.Update(country);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
