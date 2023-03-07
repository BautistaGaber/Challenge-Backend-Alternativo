using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.DTOs
{
    public class CreateCountryDTO
    {
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int Habitants { get; set; }
        public decimal TotalArea { get; set; }
    }
}
