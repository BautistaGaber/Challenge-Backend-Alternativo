using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.DTOs
{
    public class CreateGeographicIconsDTO
    {
        public string Image { get; set; }
        public string Denomination { get; set; }
        public DateTime Creation { get; set; }
        public int height { get; set; }
        public string History { get; set; }
    }
}
