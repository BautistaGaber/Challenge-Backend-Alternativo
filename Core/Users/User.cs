using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.Core.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public byte PasswordHash { get; set; }

        public byte PasswordSalt { get; set; }

    }
}
