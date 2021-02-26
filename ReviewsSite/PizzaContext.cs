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
                },
                new Toppings()
                {
                    Id = 3,
                    Name = "Sausage",
                    Description = "Coarsely ground pork (and sometimes beef) with fennel, also known as “mild” Italian sausage.",
                    IsVegetarian = false,
                    Img = "Sausage.png"
                },
                new Toppings()
                {
                    Id = 4,
                    Name = "Pineapple",
                    Description = "A large juicy tropical fruit consisting of aromatic edible yellow flesh surrounded by a tough segmented skin and topped with a tuft of stiff leaves.",
                    IsVegetarian = true,
                    Img = "Pineapple.png"
                },
                new Toppings()
                {
                    Id = 5,
                    Name = "Bacon",
                    Description = "Bacon is a type of salt-cured pork made from various cuts, typically from the pork belly or from the less fatty back cuts.",
                    IsVegetarian = false,
                    Img = "Bacon.png"
                },
                new Toppings()
                {
                    Id = 6,
                    Name = "Mushrooms",
                    Description = "An enlarged complex aboveground fleshy fruiting body of a fungus (such as a basidiomycete) that consists typically of a stem bearing a pileus.",
                    IsVegetarian = true,
                    Img = "Mushroom.png"
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
                     ReviewerName = "Carlos Lopez",
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
                  },
                  new Review()
                  {
                      ReviewId = 5,
                      ReviewContent = "I like my sausage bulky, like me.",
                      ReviewerName = "Dwayne 'The Rock' Johnson",
                      ReviewScore = 5,
                      ToppingsId = 3 
                  },
                  new Review()
                  {
                      ReviewId = 6,
                      ReviewContent = "Better than pepperoni.",
                      ReviewerName = "Davis Murphy",
                      ReviewScore = 4,
                      ToppingsId = 3
                  },
                  new Review()
                  {
                      ReviewId = 7,
                      ReviewContent = "I love pineapple so much that I live in one.",
                      ReviewerName = "SpongeBob SquarePants",
                      ReviewScore = 5,
                      ToppingsId = 4
                  },
                  new Review()
                  {
                      ReviewId = 8,
                      ReviewContent = "I hate pineapples because my neighbor lives in one.",
                      ReviewerName = "Squidward Tentacles",
                      ReviewScore = 0,
                      ToppingsId = 4
                  },
                  new Review()
                  {
                      ReviewId = 9,
                      ReviewContent = "It sucks.  It's Great!",
                      ReviewerName = "CatDog",
                      ReviewScore = 3,
                      ToppingsId = 5
                  },
                  new Review()
                  {
                      ReviewId = 10,
                      ReviewContent = "I always need more.",
                      ReviewerName = "Clifford The Big Red Dog",
                      ReviewScore = 4,
                      ToppingsId = 5
                  },
                  new Review()
                  {
                      ReviewId = 11,
                      ReviewContent = "MUSHROOMS!",
                      ReviewerName = "Peregrin 'Pippin' Took",
                      ReviewScore = 5,
                      ToppingsId = 6,
                  },
                  new Review()
                  {
                      ReviewId = 12,
                      ReviewContent = "Zoinks Scoob! Like, sign me up for more man.",
                      ReviewerName = "Shaggy",
                      ReviewScore = 5,
                      ToppingsId = 6
                  }
             ); 
        }
    }
}
