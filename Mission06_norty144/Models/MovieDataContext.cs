using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_norty144.Models
{
    public class MovieDataContext : DbContext
    {
        //Constructor
        public MovieDataContext (DbContextOptions<MovieDataContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(

                //seeded entries
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "Batman",
                    Year = "1989",
                    Director = "Tim Burton",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Action",
                    Title = "Harry Potter and the Chamber of Secrets",
                    Year = "2002",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "",
                    Notes = "",
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "X-Men",
                    Year = "2000",
                    Director = "Bryan Singer",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                }
            );
        }
    }
}
