using ChallengeAlternativo.Core.Users.Repository.Interfaces;
using ChallengeAlternativo.Core.Users.Services.Interfaces;
using ChallengeAlternativo.Helper;
using System.Security.Cryptography;
using System.Text;

namespace ChallengeAlternativo.Core.Users.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _repository;

        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> CreateUser(UserDTO userDTO)
        {
            User user = ApiHelper.CreateUserToEntity(userDTO);
            //CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
            
            user.UserName = userDTO.UserName;
            user.Password = ApiHelper.EncriptarContraseña(userDTO.Password);

            var result = await _repository.CreateUser(user);
            return result;
        }


        //public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        //{
        //    using (var hmac = new HMACSHA512())
        //    {
        //        passwordSalt = hmac.Key;
        //        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        //    }
        //}

        

        public async Task<User> GetUserById(int id)
        {
            return await _repository.GetUserById(id);
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            return await _repository.GetUserByUserName(userName);           
        }

        //public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        //{
        //    using (var hmac = new HMACSHA512(passwordSalt))
        //    {
        //        var coputedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        return coputedHash.SequenceEqual(passwordHash);
        //    }
        //}
    }
}
