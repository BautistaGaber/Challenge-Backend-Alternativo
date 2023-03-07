using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.DTOs
{
    public class CreateCountryDTO
    {
        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Denomination")]
        public string Denomination { get; set; }

        [Required]
        [Display(Name = "Habitants")]
        public int Habitants { get; set; }

        [Required]
        [Display(Name = "TotalArea")]
        public decimal TotalArea { get; set; }

    }
}
