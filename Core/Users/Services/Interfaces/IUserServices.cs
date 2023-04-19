namespace ChallengeAlternativo.Core.Users.Services.Interfaces
{
    public interface IUserServices
    {
        Task<User> GetUserById(int id);
        Task<User> GetUserByUserName(string userName);
        Task<User> CreateUser(UserDTO userDTO);
    }
}
