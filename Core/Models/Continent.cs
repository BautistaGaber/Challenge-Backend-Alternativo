using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.Models
{
    public class Continent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Denomination")]
        public string Denomination { get; set; }

        public ICollection<Country> Country { get; set; } = new List<Country>();

        public ICollection<GeographicIcons> GeographicIcons { get; set; } = new List<GeographicIcons>();
    }
}
