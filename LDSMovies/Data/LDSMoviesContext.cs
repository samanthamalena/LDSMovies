﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LDSMovies.Models;

namespace LDSMovies.Models
{
    public class LDSMoviesContext : DbContext
    {
        public LDSMoviesContext (DbContextOptions<LDSMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMovies.Models.Movie> Movie { get; set; }
    }
}
