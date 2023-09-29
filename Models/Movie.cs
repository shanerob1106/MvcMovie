using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; } // primary key
    public string? Title { get; set; }  // ? means nullable Title

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; } 
    public string? Genre { get; set; } 

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}