using ChallengeAlternativo.DTOs;
using System.ComponentModel.DataAnnotations;

namespace ChallengeAlternativo.Models
{
    public class Country
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
        [Display(Name = "Habitants")]
        public int Habitants { get; set; }

        [Required]
        [Display(Name = "TotalArea")]
        public decimal TotalArea { get; set; }  
        
        public ICollection<GeographicIcons> GeographicIcons { get; set; } = new List<GeographicIcons>();

        public Country()
        {
        }
    }
}
