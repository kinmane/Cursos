using System.ComponentModel.DataAnnotations;

namespace RazorPagesFilmes.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Tittle { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
