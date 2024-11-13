using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Model
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Informe o nome do filme.")]
        [StringLength(40, MinimumLength = 2)]
        public string Tittle { get; set; } = string.Empty;

        [Display(Name = "Gênero")]
        [RegularExpression(@"^[a+zA-Z\s]*$")]
        [Required(ErrorMessage = "Informe o gênero do filme.")]
        [StringLength(15, MinimumLength = 3)]
        public string Genre { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(0,5)]
        public int Rating { get; set; } = 0;
    }
}
