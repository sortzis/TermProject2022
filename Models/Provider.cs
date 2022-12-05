using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Provider
    {
        [Key]
        public string ProviderId { get; set; }

        [Required(ErrorMessage = "Name of Provider is required")]
        public string Name { get; set; }
    }
}
