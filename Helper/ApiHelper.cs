using ChallengeAlternativo.Core.Users;
using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;
using System.Security.Cryptography;
using System.Text;

namespace ChallengeAlternativo.Helper
{
    public class ApiHelper
    {
        public static Country CreateCountryDtoToEntity(CreateCountryDTO dto)
        {
            Country country = new Country();
            country.TotalArea = dto.TotalArea;
            country.Habitants = dto.Habitants;
            country.Denomination = dto.Denomination;
            country.Image = dto.Image;

            return country;
        }

        public static GeographicIcons CreateGeographicIconsDtoToEntity(CreateGeographicIconsDTO dto)
        {
            GeographicIcons geographicIcons = new GeographicIcons();
            geographicIcons.height = dto.height;
            geographicIcons.History = dto.History;
            geographicIcons.Denomination = dto.Denomination;
            geographicIcons.Image = dto.Image;
            geographicIcons.Creation = dto.Creation;

            return geographicIcons;
        }

        public static User CreateUserToEntity(UserDTO dto)
        {
            User user = new User();
            user.UserName = dto.UserName;
            user.Password = dto.Password;

            return user;
        }


        public static GeographicIcons UpdateGeographicIconsDtoToEntity(UpdateGeographicIconsDTO dto, GeographicIcons geographicIcons)
        {
            geographicIcons.height = dto.height;
            geographicIcons.Creation = dto.Creation;
            geographicIcons.Denomination = dto.Denomination;
            geographicIcons.History = dto.History;
            geographicIcons.Image = dto.Image;

            return geographicIcons;
        }

        public static Country UpdateCountryDtoToEntity(UpdateCountryDTO dto, Country country)
        {
            country.TotalArea = dto.TotalArea;
            country.Denomination = dto.Denomination;
            country.Habitants = dto.Habitants;
            country.Image = dto.Image;

            return country;

        }
        public static string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerificarContraseña(string userpassword, string DTOpassword)
        {
            return userpassword.Equals(DTOpassword);
        }

    }
}
