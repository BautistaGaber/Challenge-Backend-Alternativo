using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.DTOs
{
    public class ViewCountryDTO
    {
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int Habitants { get; set; }

        public ViewCountryDTO(Country c)
        {
            Image = c.Image;
            Denomination = c.Denomination;
            Habitants = c.Habitants;
        }
    }
}
