using System.ComponentModel.DataAnnotations;

namespace ALLUP2.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 800)]
        public string Description { get; set; }
    }
}
