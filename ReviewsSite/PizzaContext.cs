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
                    Description = "Pepperoni is an American variety of salami, made from cured pork and beef seasoned with paprika or other chili pepper.",
                    IsVegetarian = false,
                    Img = "Pepperoni.png"
                },
                new Toppings()
                {
                    Id = 2,
                    Name = "Green Pepper",
                    Description = "The mild-flavored, unripe fruit of the bell or sweet pepper, Capsicum annuum grossum, used as a green vegetable.",
                    IsVegetarian = true,
                    Img = "GPepper.png"
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    ReviewId = 1,
                    ReviewContent = "If it isn't Doge coin... At least it's shaped like a coin. #SpaceX",
                    ReviewerName = "Elon Musk",
                    ReviewScore = 4,
                    ToppingsId = 1
                },
                new Review()
                {
                    ReviewId = 2,
                    ReviewContent = "Ruh Ro Raggy! Resse Aren't Scooby Snacks!!!",
                    ReviewerName = "Scooby Doo",
                    ReviewScore = 2,
                    ToppingsId = 2
                },
                 new Review()
                 {
                     ReviewId = 3,
                     ReviewContent = "The only thing better than this topping is the review(Site)",
                     ReviewerName = "Carlos",
                     ReviewScore = 5,
                     ToppingsId = 1
                 },
                  new Review()
                  {
                      ReviewId = 4,
                      ReviewContent = "Pika Pika, Pikachu!",
                      ReviewerName = "Pikachu",
                      ReviewScore = 1,
                      ToppingsId = 2
                  }
             ); 
        }
    }
}
