using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Director
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Details { get; set; }
    }
}
