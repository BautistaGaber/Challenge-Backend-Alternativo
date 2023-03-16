using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.DTOs
{
    public class ViewGeographicIconsDTO
    {
        public string Image { get; set; }
        public string Denomination { get; set; }


        public ViewGeographicIconsDTO(GeographicIcons g)
        {
            Image = g.Image;
            Denomination = g.Denomination;
        }
    }
}
