using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{


    public class Toppings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public string Review { get; set; }

        public Toppings()
        {

        }

        public Toppings(int id, string name, string description, bool isVegetarian, string review)
        {
            Id = id;
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Review = review;
        }

    }
}
