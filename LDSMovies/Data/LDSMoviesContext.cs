using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LDSMovie.Models;

namespace LDSMovies.Models
{
    public class LDSMoviesContext : DbContext
    {
        public LDSMoviesContext (DbContextOptions<LDSMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMovie.Models.Movie> Movie { get; set; }
    }
}
