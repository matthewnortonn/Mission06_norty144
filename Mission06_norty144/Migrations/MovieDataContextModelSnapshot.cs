// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_norty144.Models;

namespace Mission06_norty144.Migrations
{
    [DbContext(typeof(MovieDataContext))]
    partial class MovieDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_norty144.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Tim Burton",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Batman",
                            Year = "1989"
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Action",
                            Director = "Chris Columbus",
                            Edited = true,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Harry Potter and the Chamber of Secrets",
                            Year = "2002"
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Action",
                            Director = "Bryan Singer",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "X-Men",
                            Year = "2000"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
