using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please enter a year for release date.")]
        [Range(1980, 2050, ErrorMessage = "Please enter a release date between 1980 and now.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a number for stars.")]
        [Range(1, 10, ErrorMessage = "Stars must be between 1 and 10.")]
        public double? Rating { get; set; }

        [ForeignKey("ProviderId")]
        public string ProviderId { get; set; }

    }
}
