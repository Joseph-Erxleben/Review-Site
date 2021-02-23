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
                    Review = "Review"
                },
                new Toppings()
                {
                    Id = 2,
                    Name = "Green Pepper",
                    Description = "Delicious",
                    IsVegetarian = true,
                    Review = "Review"
                }
            );
        }
    }
}
