using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Tittle { get; set; } = string.Empty;

        [Display(Name = "Gênero")]
        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int Rating { get; set; } = 0;
    }
}
