using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;

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

    }
}
