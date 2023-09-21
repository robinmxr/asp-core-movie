using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Genre { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public Director Director { get; set; }

    [DisplayName("Director")]
    public int DirectorId { get; set; }

}