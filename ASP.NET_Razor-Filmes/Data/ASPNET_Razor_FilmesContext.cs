using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Model;

namespace ASP.NET_Razor_Filmes.Data
{
    public class ASPNET_Razor_FilmesContext : DbContext
    {
        public ASPNET_Razor_FilmesContext (DbContextOptions<ASPNET_Razor_FilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilmes.Model.Filme> Filme { get; set; } = default!;
    }
}
