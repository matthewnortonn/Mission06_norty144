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
        public DbSet<Category> Categories { get; set; }



        //seeding data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Action" },
                    new Category { CategoryID = 2, CategoryName = "Adventure" },
                    new Category { CategoryID = 3, CategoryName = "Comedy" },
                    new Category { CategoryID = 4, CategoryName = "Drama" },
                    new Category { CategoryID = 5, CategoryName = "Horror" },
                    new Category { CategoryID = 6, CategoryName = "Romance" },
                    new Category { CategoryID = 7, CategoryName = "Thriller" },
                    new Category { CategoryID = 8, CategoryName = "Fantasy" },
                    new Category { CategoryID = 9, CategoryName = "Mystery" },
                    new Category { CategoryID = 10, CategoryName = "Western" },
                    new Category { CategoryID = 11, CategoryName = "Sports" },
                    new Category { CategoryID = 12, CategoryName = "Science Fiction" },
                    new Category { CategoryID = 13, CategoryName = "Musical" }
                );


            mb.Entity<MovieResponse>().HasData(

                //seeded entries
                new MovieResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
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
                    CategoryID = 1,
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
                    CategoryID = 1,
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
