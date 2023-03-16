using ChallengeAlternativo.Models;

namespace ChallengeAlternativo.DTOs
{
    public class UpdateCountryDTO
    {
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int Habitants { get; set; }
        public decimal TotalArea { get; set; }
    }
}
