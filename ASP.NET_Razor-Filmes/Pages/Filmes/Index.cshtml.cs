using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Razor_Filmes.Data;
using RazorPagesFilmes.Model;

namespace ASP.NET_Razor_Filmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly ASP.NET_Razor_Filmes.Data.ASPNET_Razor_FilmesContext _context;

        public IndexModel(ASP.NET_Razor_Filmes.Data.ASPNET_Razor_FilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Filme != null)
            {
                Filme = await _context.Filme.ToListAsync();
            }
        }
    }
}
