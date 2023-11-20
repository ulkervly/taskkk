using System.ComponentModel.DataAnnotations;

namespace ALLUP2.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Title1 { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Title2 { get; set; }
        [Required]
        [StringLength(maximumLength: 800)]
        public string Description { get; set; }
        public string RedirectUrl { get; set; }
        public string ImageUrl { get; set; }

    }
}
