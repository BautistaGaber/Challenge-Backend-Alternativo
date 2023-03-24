using ChallengeAlternativo.Core.Users.Repository.Interfaces;
using ChallengeAlternativo.Data;

namespace ChallengeAlternativo.Core.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AplicationDbContext _context;
        public UserRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
