namespace ChallengeAlternativo.Core.Users.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByUserName(string userName);
        Task<User> CreateUser(User user);
    }
}
