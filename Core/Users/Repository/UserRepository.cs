using ChallengeAlternativo.Core.Users.Repository.Interfaces;
using ChallengeAlternativo.Data;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlternativo.Core.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AplicationDbContext _context;
        public UserRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
            return user;            
        }

        public async Task<User> GetUserById(int id)
        {
            var result = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            return result;
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            var result = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            return result;
        }
    }
}
