using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Data;
using RazorPagesFilmes.Model;

namespace RazorPagesFilmes.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesFilmes.Data.RazorPagesFilmesContext _context;

        public IndexModel(RazorPagesFilmes.Data.RazorPagesFilmesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string TermoBusca { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilmeGenero { get; set; }
        
        public SelectList Generos { get; set; }

        public async Task OnGetAsync()
        {
            var filmes = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(TermoBusca))
            {
                filmes = filmes.Where(f => f.Tittle.Contains(TermoBusca));
            }

            if (_context.Movie != null)
            {
                Movie = await filmes.ToListAsync();
            }
        }
    }
}
