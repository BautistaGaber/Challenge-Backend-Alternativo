using ChallengeAlternativo.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlternativo.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Country> countries { get; set; }
        public DbSet<Continent> continents { get; set; }
        public DbSet<GeographicIcons> GeographicIcons { get; set; }
    }
}
