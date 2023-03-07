using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.Models
{
    public class GeographicIcons
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Denomination")]
        public string Denomination { get; set; }

        [Required]
        [Display(Name = "Creation")]
        public DateTime Creation { get; set; }

        [Required]
        [Display(Name = "height")]
        public int height { get; set; }

        [Required]
        [Display(Name = "History")]
        public string History { get; set; }

        public ICollection<Country> Country { get; set; } = new List<Country>();
    }
}
