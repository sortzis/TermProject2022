using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class ShowContext : DbContext
    {
        public ShowContext(DbContextOptions<ShowContext> options) :base(options) { }
        public DbSet<Show> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>().HasData(
                new Show
                {
                    ShowId = 1,
                    Title = "Love is Blind",
                    Year = 2020,
                    Rating = 5.75
                },
                new Show
                {
                    ShowId = 2,
                    Title = "Jersey Shore",
                    Year = 2009,
                    Rating = 3.25
                },
                new Show
                {
                    ShowId = 3,
                    Title = "The Bachelorette",
                    Year = 2003,
                    Rating = 6.25
                }

                );
        }
    }
}
