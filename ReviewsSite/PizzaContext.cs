using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;
using Microsoft.EntityFrameworkCore;

namespace ReviewsSite
{
    public class PizzaContext : DbContext
    {
        public DbSet<Toppings> Toppings { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=PizzaDB_102021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Toppings>().HasData(
                new Toppings()
                {
                    Id = 1,
                    Name = "Pepperoni",
                    Description = "Delicious",
                    IsVegetarian = false,
                    Img = "Pepperoni.png"
                },
                new Toppings()
                {
                    Id = 2,
                    Name = "Green Pepper",
                    Description = "Delicious",
                    IsVegetarian = true,
                    Img = "GPepper.png"
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    ReviewId = 1,
                    ReviewContent = "Content Area",
                    ReviewerName = "Elon Musk",
                    ReviewScore = 4,
                    ToppingsId = 1
                },
                new Review()
                {
                    ReviewId = 2,
                    ReviewContent = "Area of Content",
                    ReviewerName = "Scooby Doo",
                    ReviewScore = 2,
                    ToppingsId = 2
                }
             ); 
        }
    }
}
