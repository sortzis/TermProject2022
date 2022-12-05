using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class ShowContext : DbContext
    {
        public ShowContext(DbContextOptions<ShowContext> options) :base(options) { }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasData(
                new Provider { ProviderId = "N", Name = "Netflix" },
                new Provider { ProviderId = "M", Name = "MTV" },
                new Provider { ProviderId = "A", Name = "ABC" });

            modelBuilder.Entity<Show>().HasData(
                new Show
                {
                    ShowId = 1,
                    Title = "Love is Blind",
                    Year = 2020,
                    Rating = 5.75,
                    ProviderId = "N"
                },
                new Show
                {
                    ShowId = 2,
                    Title = "Jersey Shore",
                    Year = 2009,
                    Rating = 3.25,
                    ProviderId = "M"
                },
                new Show
                {
                    ShowId = 3,
                    Title = "The Bachelorette",
                    Year = 2003,
                    Rating = 6.25,
                    ProviderId = "A"
                }

                );
        }
    }
}
